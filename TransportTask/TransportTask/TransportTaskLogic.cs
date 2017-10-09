using System;
using System.IO;
using System.Linq;

namespace vector
{
    /// <summary>
    /// Класс предназначен для решения транспортной задачи различными методами и возможностью оптимизации
    /// </summary>
    internal static class TransportTask
    {
        /// <summary>
        /// Осуществляет проверку данных
        /// </summary>
        /// <param name="a">Массив поставщиков</param>
        /// <param name="b">Массив потребителей</param>
        /// <param name="c">Матрица поставок</param>
        public static void Check(int[] a, int[] b, Element[,] c)
        {
            if (c == null) throw new Exception("Матрица содержит пустые ячейки");
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));
            if (a.Sum() != b.Sum()) throw new Exception("Сумма продуктов у поставщиков должна быть равна сумме продуктов необходимых потребителям");
        }
        /// <summary>
        /// Тип предназначен для отдельной ячейки, включает расширенную информацию
        /// </summary>
        internal struct Element
        {
            /// <summary>
            /// Размер поставки
            /// </summary>
            public int Delivery { get; set; }
            /// <summary>
            /// Стоимость поставки
            /// </summary>
            public int Value { get; set; }
            /// <summary>
            /// Коэффициент очередности
            /// </summary>
            public double Coefficient { get; set; }
            /// <summary>
            /// Был ли использован при распределении поставки (метод Лебедева)
            /// </summary>
            public bool WasUsed { get; set; }
        }
        /// <summary>
        /// Находит минимальный элемент из возможных двух целых чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Минимальный элемент</returns>
        private static int FindMin(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }
        /// <summary>
        /// Преобразовывает матрицу и массивы в одну целую матрицу
        /// </summary>
        /// <param name="s">Строка, указывающая требуемую матрицу - исходную или решенную (source/result)</param>
        /// <param name="a">Массив поставщиков</param>
        /// <param name="b">Массив потребителей</param>
        /// <param name="c">Матрица, включающая в себя стоимость поставок и размер поставок </param>
        /// <returns>Матрицу, включающую в себя стоимость поставок или размер поставок а также массивы поставщиков и потребителей</returns>
        private static int[,] ConvertTo2DArray(string s, int[] a, int[] b, Element[,] c)
        {
            int[,] d = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i < b.Length; i++)
            {
                d[0, i + 1] = b[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                d[i + 1, 0] = a[i];
            }
            if (s == "result")
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        d[i + 1, j + 1] = c[i, j].Delivery;
                    }
                }
                return d;
            }
            else if (s == "source")
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        d[i + 1, j + 1] = c[i, j].Value;
                    }
                }
                return d;
            }
            else throw new ArgumentException("Неверный параметр s");
        }
        /// <summary>
        /// Выравнивает матрицу
        /// </summary>
        /// <param name="a">Количество строк  матрицы</param>
        /// <param name="b">Количество столбцов матрицы</param>
        /// <param name="d">Матрица, которую нужно выровнять</param>
        /// <returns>Строковое представление выравненной матрицы</returns>
        private static string GetStr(int a, int b, int[,] d)
        {
            int arrayMax = d[0, 0];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b - 1; j++)
                {
                    if (arrayMax.ToString().Length <= d[i, j + 1].ToString().Length)
                        arrayMax = d[i, j + 1];
                }
            }
            int cs = arrayMax.ToString().Length + 2;
            string tmp = "";
            for (int i = 0; i < a + 1; i++)
            {
                for (int j = 0; j < b + 1; j++)
                {
                    tmp += String.Format("{0," + cs.ToString() + "}", d[i, j]);
                }
                if (i != a)
                    tmp += "\r\n";
            }
            return tmp;
        }
        /// <summary>
        /// Решает задачу методом Лебедева
        /// </summary>
        /// <param name="a">Массив поставщиков</param>
        /// <param name="b">Массив потребителей</param>
        /// <param name="c">Изменяемая матрица, включающая в себя стоимость поставок</param>
        internal static string LastMethodUsed = "";
        internal static void LebedevMethod(int[] a, int[] b, ref Element[,] c)
        {
            Check(a, b, c);
            int[] e = new int[a.Length];
            Array.Copy(a, e, a.Length);
            int[] f = new int[b.Length];
            Array.Copy(b, f, b.Length);
            //Среднее по строкам
            double[] avrgRowSumm = new double[e.Length];
            for (int k = 0; k < e.Length; k++)
            {
                for (int l = 0; l < f.Length; l++)
                {
                    avrgRowSumm[k] += c[k, l].Value;
                }
                avrgRowSumm[k] /= f.Length;
            }
            //Среднее по столбцам
            double[] avrgColSumm = new double[f.Length];
            for (int l = 0; l < f.Length; l++)
            {
                for (int k = 0; k < e.Length; k++)
                {
                    avrgColSumm[l] += c[k, l].Value;
                }
                avrgColSumm[l] /= e.Length;
            }
            Tuple<int, int> minIndex = new Tuple<int, int>(0, 0);
            //Коэффициент очередности
            for (int k = 0; k < e.Length; k++)
            {
                for (int l = 0; l < f.Length; l++)
                {
                    c[k, l].Coefficient = avrgRowSumm[k] + avrgColSumm[l] - c[k, l].Value;
                    if (c[k, l].Coefficient < c[minIndex.Item1, minIndex.Item2].Coefficient)
                    {
                        minIndex = Tuple.Create(k, l);
                    }
                }
            }
            Tuple<int, int> index = new Tuple<int, int>(0, 0);
            while (e.Sum() + f.Sum() != 0)
            {
                for (int k = 0; k < e.Length; k++)
                {
                    for (int l = 0; l < f.Length; l++)
                    {
                        if (c[k, l].Coefficient >= c[index.Item1, index.Item2].Coefficient && c[k, l].WasUsed == false)
                        {
                            index = Tuple.Create(k, l);
                        }
                    }
                }
                c[index.Item1, index.Item2].WasUsed = true;
                c[index.Item1, index.Item2].Delivery = FindMin(e[index.Item1], f[index.Item2]);
                e[index.Item1] -= c[index.Item1, index.Item2].Delivery;
                f[index.Item2] -= c[index.Item1, index.Item2].Delivery;
                index = minIndex;
            }
            LastMethodUsed = "\r\nРешение транспортной задачи методом Лебедева: \r\n";
        }
        /// <summary>
        /// Решает задачу методом северо-западного угла
        /// </summary>
        /// <param name="a">Массив поставщиков</param>
        /// <param name="b">Массив потребителей</param>
        /// <param name="c">Изменяемая матрица, включающая в себя стоимость поставок</param>
        internal static void NorthWestCornerMethod(int[] a, int[] b, ref Element[,] c)
        {
            Check(a, b, c);
            int[] e = new int[a.Length];
            Array.Copy(a, e, a.Length);
            int[] f = new int[b.Length];
            Array.Copy(b, f, b.Length);
            int i = 0;
            int j = 0;
            while (i < e.Length && j < f.Length)
            {
                try
                {
                    if (e[i] == 0)
                    {
                        i++;
                    }
                    if (f[j] == 0)
                    {
                        j++;
                    }
                    if (e[i] == 0 && f[j] == 0)
                    {
                        i++;
                        j++;
                    }
                    c[i, j].Delivery = FindMin(e[i], f[j]);
                    e[i] -= c[i, j].Delivery;
                    f[j] -= c[i, j].Delivery;
                }
                catch
                {
                    
                }
            }
            LastMethodUsed = "\r\nРешение транспортной задачи методом Северо-западного угла: \r\n";
        }

        internal static bool WasUsedOpt = false;
        private static Element[,] res;
        /// <summary>
        /// Оптимизирует матрицу методом квадратов
        /// </summary>
        /// <param name="n">Количество строк оптимизируемой матрицы</param>
        /// <param name="m">Количество столбцов оптимизируемой матрицы</param>
        /// <param name="c">Изменяемая матрица, включающая в себя стоимость поставок и размер поставок</param>
        internal static void SquareOptimization(int n, int m, ref Element[,] c)
        {
            Array.Copy(c, res = new Element[n, m], n * m);
            bool flag = true;
            for (int i = 0; i < n; i++)
            {
                flag = true;
                for (int j = 0; j < m && flag; j++)
                {
                    if (c[i, j].Delivery != 0)
                    {
                        for (int x = i + 1; x < n && flag; x++)
                        {
                            for (int y = 0; y < m && flag; y++)
                            {
                                if (c[x, y].Delivery != 0)
                                {
                                    if (c[i, j].Value + c[x, y].Value > c[x, j].Value + c[i, y].Value)
                                    {
                                        int value = FindMin(c[i, j].Delivery, c[x, y].Delivery);
                                        c[x, j].Delivery += value;
                                        c[i, y].Delivery += value;
                                        c[i, j].Delivery -= value;
                                        c[x, y].Delivery -= value;
                                        i = -1;
                                        flag = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            WasUsedOpt = true;
        }
        /// <summary>
        /// Возвращает значение PLbas или PLopt
        /// </summary>
        /// <param name="s">Строка, указывающая какое значение возвращать (bas/opt)</param>
        /// <param name="n">Количество строк в матрице</param>
        /// <param name="m">Количество столбцов в матрице</param>
        /// <param name="c">Матрица, значение PL которой нужно посчитать</param>
        /// <returns>Подробное строковое представление нахождения значения PLbas и общий результат</returns>
        internal static string Pl(string s, int n, int m, Element[,] c)
        {
            int ResultFunction = 0;
            string ResultFunctionstr = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ResultFunction += (c[i, j].Value * c[i, j].Delivery);
                    if (c[i, j].Delivery != 0)
                    {
                        ResultFunctionstr += c[i, j].Value + "⋅" + c[i, j].Delivery + "+";
                    }
                }
            }
            ResultFunctionstr = ResultFunctionstr.Remove(ResultFunctionstr.Length - 1);
            return "PL" + s + "=" + ResultFunctionstr + "=" + ResultFunction;
        }
        /// <summary>
        /// Сохраняет данные в файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="a">Массив поставщиков</param>
        /// <param name="b">Массив потребителей</param>
        /// <param name="c">Матрица, включающая в себя стоимость поставок и размер поставок</param>
        internal static void SaveFile(string path, int[] a, int[] b, Element[,] c)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if (sw.BaseStream.Position != 0)
                sw.WriteLine("-----------------------");
            sw.WriteLine("Исходные данные:\r\n" + GetStr(a.Length, b.Length, ConvertTo2DArray("source", a, b, c)));
            if (LastMethodUsed.Length != 0)
                if (WasUsedOpt == true)
                {
                    sw.WriteLine(LastMethodUsed + GetStr(a.Length, b.Length, ConvertTo2DArray("result", a, b, res)) +"\r\n" + Pl("bas", a.Length, b.Length, res) + "\r\n" +
                        "\r\nОптимизация методом квадратов:\r\n" + GetStr(a.Length, b.Length, ConvertTo2DArray("result", a, b, c)) + "\r\n" + Pl("opt", a.Length, b.Length, c) + "\r\n");
                }
                else
                {
                    sw.WriteLine(LastMethodUsed + GetStr(a.Length, b.Length, ConvertTo2DArray("result", a, b, c)) + "\r\n" + Pl("bas", a.Length, b.Length, c));
                }
            sw.Close();
        }
        /// <summary>
        /// Загружает данные из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="a">Массив поставщиков</param>
        /// <param name="b">Массив потребителей</param>
        /// <param name="c">Матрица, в которую запишутся данные о стоимости поставок</param>
        internal static void LoadFile(string path, ref int[] a, ref int[] b, ref Element[,] c)
        {
            string text = File.ReadAllText(path);
            string[] A = text.Split('\n');
            string[] B = A[0].Remove(A[0].Length - 1).Split(' ');
            int[] ta = new int[A.Length - 1];
            int[] tb = new int[B.Length - 1];
            Element[,] tc = new Element[ta.Length, tb.Length];
            for (int i = 0; i < A.Length - 1; i++)
            {
                ta[i] = Convert.ToInt32(A[i + 1].Split(' ').First());
            }
            for (int i = 0; i < B.Length - 1; i++)
            {
                tb[i] = Convert.ToInt32(B[i + 1]);
            }

            int[] tmp =
            Array.ConvertAll<string, int>(
            text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

            for (int i = 0; i < ta.Length; i++)
            {
                for (int j = 0; j < tb.Length; j++)
                {
                    tc[i, j].Value = i != 0 ? tmp[B.Length * (i + 1) + 1 + j] : tmp[B.Length + 1 + j];
                }
            }
            a = ta;
            b = tb;
            c = tc;
        }

    }
}