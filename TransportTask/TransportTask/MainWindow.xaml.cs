using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using Brushes = System.Windows.Media.Brushes;
using Color = System.Windows.Media.Color;

namespace vector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly WindowAbout _winAbout = new WindowAbout();

        [DebuggerStepThrough]
        #region WindowBehavior
        public MainWindow()
        {
            InitializeComponent();
            new LoginWindow().ShowDialog();
            BlurClientAreaBottom.Background = new VisualBrush()
            {
                AlignmentX = AlignmentX.Left,
                AlignmentY = AlignmentY.Top,
                Stretch = Stretch.None,
                Visual = ScrolledContent,
                ViewboxUnits = BrushMappingMode.Absolute,
                Viewbox = new Rect(0, ScrolledContent.ActualHeight - BlurClientAreaBottom.ActualHeight, 1, 1),
            };
        }
       
        private void ScrolledContent_LayoutUpdated(object sender, EventArgs e)
        {
            ((BlurClientAreaBottom.Background) as VisualBrush).Viewbox = new Rect(0, ScrolledContent.ActualHeight - BlurClientAreaBottom.ActualHeight, 1, 1);
        }
        private void ButtonCommonClick(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button)?.Name)
            {
                case "ButtonClose":
                    Close();
                    return;
                case "ButtonMaximize":
                    WindowState = WindowState.Maximized;
                    return;
                case "ButtonRestore":
                    WindowState = WindowState.Normal;
                    return;
                case "ButtonMinimize":
                    WindowState = WindowState.Minimized;
                    return;
            }
        }
        private void Window_StateChanged(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case WindowState.Maximized:
                    ButtonMaximize.Visibility = Visibility.Collapsed;
                    ButtonRestore.Visibility = Visibility.Visible;
                    break;
                case WindowState.Normal:
                    ButtonMaximize.Visibility = Visibility.Visible;
                    ButtonRestore.Visibility = Visibility.Collapsed;
                    break;
            }
        }
        [DebuggerStepThrough]
        private void Window_Deactivated(object sender, EventArgs e)
        {
            ((Canvas)FindResource("TiledBackground")).Background =
                ((Canvas)FindResource("TiledBackgroundBottom")).Background =
                    Brushes.DimGray;
        }
        [DebuggerStepThrough]
        private void Window_Activated(object sender, EventArgs e)
        {
            ((Canvas)FindResource("TiledBackground")).Background =
                ((Canvas)FindResource("TiledBackgroundBottom")).Background =
                    FindResource("WindowColor") as SolidColorBrush;
        }

        #endregion

        private TransportTask.Element[,] _matrix;
        private int[] _a;
        private int[] _b;
        private int _n, _m;

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var mi = sender as MenuItem;
            CloseSizePanel();
            if (Equals(mi, MenuItemInKb))
            {
                ClearGridMatrix();
                LabelResult.Content = "";
                MenuItemLebedev.IsEnabled = MenuItemNorWestCorner.IsEnabled = true;
                MenuItemOptimization.IsEnabled = false;
                TboxM.IsTabStop = TboxN.IsTabStop = true;
                TboxN.Clear();
                TboxM.Clear();
                TboxN.Focus();
                TransportTask.LastMethodUsed = "";
                TransportTask.WasUsedOpt = false;
            }
            else if (Equals(mi, MenuItemInFile))
            {
                OpenFileDialog ofd = new OpenFileDialog() { Filter = "Матрица|*.txt" };
                bool? ofdOk = ofd.ShowDialog();
                if (ofdOk == true)
                {
                    try
                    {
                        TransportTask.LoadFile(ofd.FileName, ref _a, ref _b, ref _matrix);
                    }
                    catch (Exception)
                    {
                        (FindResource("StoryboardError") as Storyboard)?.Begin();
                        ErrorBlock.Text = "Не удалось загрузить файл";
                        return;
                    }
                    ChangeGridSize(_a.Length, _b.Length);
                    PrintMatrix(false);
                    MenuItemLebedev.IsEnabled = MenuItemNorWestCorner.IsEnabled = true;
                    MenuItemOptimization.IsEnabled = false;
                    LabelResult.Content = "";
                    TransportTask.LastMethodUsed = "";
                    TransportTask.WasUsedOpt = false;
                    (FindResource("StoryboardSuccess") as Storyboard)?.Begin();
                    ErrorBlock.Text = "Файл загружен успешно";
                }
            }
            else if (Equals(mi, MenuItemOutFile))
            {
                try
                {
                    if (LabelResult.Content as string == "")
                        ReadMatrix();
                }
                catch (Exception ex)
                {
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = ex.Message;
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Матрица|*.txt" };
                bool? sfdOk = sfd.ShowDialog();
                if (sfdOk == true)
                {
                    try
                    {
                        TransportTask.SaveFile(sfd.FileName, _a, _b, _matrix);
                    }
                    catch (Exception)
                    {
                        (FindResource("StoryboardError") as Storyboard)?.Begin();
                        ErrorBlock.Text = "Не удалось сохранить файл";
                        return;
                    }
                    (FindResource("StoryboardSuccess") as Storyboard)?.Begin();
                    ErrorBlock.Text = "Файл сохранен успешно";
                }
            }
            else if (Equals(mi, MenuItemNorWestCorner))
            {
                try
                {
                    ReadMatrix();
                }
                catch (Exception ex)
                {
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = ex.Message;
                    return;
                }
                try
                {
                    TransportTask.NorthWestCornerMethod(_a, _b, ref _matrix);
                }
                catch (Exception ex)
                {
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = ex.Message;
                    return;
                }
                PrintMatrix(true);
                LabelResult.Content = TransportTask.Pl("bas", _n, _m, _matrix);
                MenuItemLebedev.IsEnabled = MenuItemNorWestCorner.IsEnabled = false;
                MenuItemOptimization.IsEnabled = true;
            }
            else if (Equals(mi, MenuItemLebedev))
            {
                try
                {
                    ReadMatrix();
                }
                catch (Exception ex)
                {
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = ex.Message;
                    return;
                }
                try
                {
                    TransportTask.LebedevMethod(_a, _b, ref _matrix);
                }
                catch (Exception ex)
                {
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = ex.Message;
                    return;
                }
                PrintMatrix(true);
                LabelResult.Content = TransportTask.Pl("bas", _n, _m, _matrix);
                MenuItemLebedev.IsEnabled = MenuItemNorWestCorner.IsEnabled = false;
                MenuItemOptimization.IsEnabled = true;
            }
            else if (Equals(mi, MenuItemOptimization))
            {
                TransportTask.SquareOptimization(_n, _m, ref _matrix);
                LabelResult.Content = TransportTask.Pl("opt", _n, _m, _matrix);
                MenuItemOptimization.IsEnabled = false;
                PrintMatrix(true);
            }
            else
            {
                if (Equals(mi, MenuItemAuthors))
                    _winAbout.State = 0;
                else if (Equals(mi, MenuItemData))
                    _winAbout.State = 1;
                else if (Equals(mi, MenuItemMethods))
                    _winAbout.State = 2;
                else if (Equals(mi, MenuItemProgramm))
                    _winAbout.State = 3;
                _winAbout.Show();
            }
        }
        void ReadMatrix()
        {
            try
            {
                for (int i = 0; i < _n; i++)
                    _a[i] = Convert.ToInt32((FindName("Tb" + (i + 1) + "_0") as TextBox)?.Text);
                for (int j = 0; j < _m; j++)
                    _b[j] = Convert.ToInt32((FindName("Tb0_" + (j + 1)) as TextBox)?.Text);
                for (int i = 0; i < _n; i++)
                    for (int j = 0; j < _m; j++)
                        _matrix[i, j].Value =
                            Convert.ToInt32((FindName("Tb" + (i + 1) + "_" + (j + 1)) as TextBox)?.Text);
            }
            catch
            {
                throw new Exception("Матрица содержит пустые ячейки");
            }
            TransportTask.Check(_a, _b, _matrix);
        }
        void PrintMatrix(bool block)
        {

            for (int i = 0; i < _n; i++)
            {
                var textBox = (TextBox)FindName("Tb" + (i + 1) + "_0");
                if (textBox != null)
                {
                    textBox.Text = _a[i].ToString();
                    textBox.IsReadOnly = block;
                }

            }
            for (int j = 0; j < _m; j++)
            {
                var textBox = (TextBox)FindName("Tb0_" + (j + 1));
                if (textBox != null)
                {
                    textBox.Text = _b[j].ToString();
                    textBox.IsReadOnly = block;
                }
            }
            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _m; j++)
                {
                    var textBox = (TextBox)FindName("Tb" + (i + 1) + "_" + (j + 1));
                    if (textBox != null)
                    {
                        if (_matrix[i, j].Delivery != 0 && block)
                        {
                            textBox.Foreground = Brushes.Blue;
                            textBox.Text =
                                $"{_matrix[i, j].Value}({_matrix[i, j].Delivery})";
                        }
                        else
                        {
                            textBox.Text =
                                $"{_matrix[i, j].Value}";
                        }
                        textBox.IsReadOnly = block;
                    }
                }
        }
        #region TextBoxSizeOfMatrix

        private void TboxNM_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var tb = sender as TextBox;
            if (e.Key == Key.Space || e.Key == Key.Right && tb?.SelectionStart == tb?.Text.Length)
            {
                if (TboxN.Equals(sender as TextBox))
                {
                    TboxM.Focus();
                    TboxM.SelectionLength = TboxM.Text.Length;
                }
                e.Handled = true;
            }
            else if ((e.Key == Key.Left || e.Key == Key.Back) && tb?.SelectionStart == 0)
            {
                TboxN.Focus();
            }

        }

        private void TboxNM_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null)
            {
                int selstrt = tb.SelectionStart;
                int sellen = tb.SelectionLength;
                if (e.Text.Length != 0 && char.GetNumericValue(e.Text[0]).Equals(-1)
                    || e.Text == "0" && tb.SelectionStart == 0)
                {
                    e.Handled = true;
                    (FindResource("StoryboardError") as Storyboard)?.Begin();

                    ErrorBlock.Text = "";

                }
                else if (tb.Text.Length != 0 &&
                    Convert.ToInt32(tb.Text.Substring(0, selstrt)
                                    + e.Text + tb.Text.Substring(selstrt + sellen)) > 100)
                {
                    e.Handled = true;
                    (FindResource("StoryboardError") as Storyboard)?.Begin();

                    ErrorBlock.Text = "Размер матрицы должен быть не более 100х100";
                }
            }
        }

        private void TboxNM_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (TboxN.Text.Length > 0 && TboxM.Text.Length > 0)
            {
                int n = Convert.ToInt32(TboxN.Text);
                int m = Convert.ToInt32(TboxM.Text);
                if (n > 1 && m > 1)
                {
                    ChangeGridSize(n, m);
                    _a = new int[n];
                    _b = new int[m];
                    _matrix = new TransportTask.Element[n, m];
                    MenuItemOptimization.IsEnabled = false;
                }
            }
        }

        private void TboxNM_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length > 0)
            {
                int i = Convert.ToInt32(((TextBox)sender).Text);
                if (i < 2)
                {
                    ((TextBox)sender).Undo();
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = "Размер матрицы должен быть не менее 2х2";
                }
            }
        }

        #endregion
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            CloseSizePanel();
        }
        private void CloseSizePanel()
        {
            (FindResource("SbInKbClose") as Storyboard)?.Begin();
            TboxM.IsTabStop = TboxN.IsTabStop = false;
        }
        public void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            _winAbout.Visibility = Visibility.Collapsed;
            CloseDialog closeDialog = new CloseDialog
            {
                Owner = this,
                ParentWindow = this
            };
            closeDialog.ShowDialog();
        }
        void ClearGridMatrix()
        {
            if (_n != 0 && _m != 0)
                for (int row = 0; row <= _n; row++)
                    for (int column = 0; column <= _m; column++)
                    {
                        var textBox = FindName("Tb" + row + "_" + column) as TextBox;
                        if (textBox != null)
                        {
                            textBox.Visibility = Visibility.Collapsed;
                            UnregisterName("Tb" + row + "_" + column);
                        }
                    }
            GridMatrix.Children.Clear();
            GridMatrix.ColumnDefinitions.Clear();
            GridMatrix.RowDefinitions.Clear();
            _n = 0;
            _m = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _winAbout.Owner = this;
        }
        void ChangeGridSize(int nn, int nm)
        {
            ClearGridMatrix();
            _n = nn;
            _m = nm;
            for (int column = 0; column <= _m; column++)
                GridMatrix.ColumnDefinitions.Add(new ColumnDefinition() { MinWidth = 30 });
            for (int row = 0; row <= _n; row++)
            {
                GridMatrix.RowDefinitions.Add(new RowDefinition() { MinHeight = 20 });
                for (int column = 0; column <= _m; column++)
                {
                    TextBox textBox = new TextBox()
                    {
                        Name = "Tb" + row + "_" + column,
                        Margin = new Thickness(1, 1, 0, 0),
                        Background =
                            (column == 0 || row == 0) ? new SolidColorBrush(Color.FromRgb(27, 77, 112)) : Background,
                        BorderBrush =
                            (column == 0 || row == 0) ? new SolidColorBrush(Color.FromRgb(27, 77, 112)) : Background,
                        FontWeight = (column == 0 || row == 0) ? FontWeights.Bold : FontWeight,
                        Foreground = (column == 0 || row == 0) ? Brushes.White : Foreground,
                        TabIndex = (column == 0 || row == 0) ? 2 : 3,
                        TextAlignment = TextAlignment.Center,
                        FontSize = 14,
                        MinWidth = 40,
                    };
                    textBox.GotFocus += TextBox_GotFocus;
                    textBox.PreviewKeyDown += TextBox_PreviewKeyDown;
                    textBox.PreviewTextInput += TextBox_PreviewTextInput;
                    textBox.SetValue(Grid.ColumnProperty, column);
                    textBox.SetValue(Grid.RowProperty, row);
                    GridMatrix.Children.Add(textBox);
                    RegisterName(textBox.Name, textBox);
                }
            }
            var tbox = FindName("Tb0_0") as TextBox;
            if (tbox != null) tbox.IsEnabled = false;
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null)
            {
                int selstrt = tb.SelectionStart;
                int sellen = tb.SelectionLength;
                if (e.Text.Length != 0 && char.GetNumericValue(e.Text[0]).Equals(-1)
                    || tb.Text.Length != 0 && e.Text == "0" && tb.SelectionStart == 0)
                {
                    e.Handled = true;
                    (FindResource("StoryboardError") as Storyboard)?.Begin();
                    ErrorBlock.Text = "Матрица должна содержать целые неотрицательные числа";
                }
            }
        }
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox nexttb;
            var tb = sender as TextBox;

            if (e.Key == Key.Space || e.Key == Key.Right && tb?.SelectionStart == tb?.Text.Length)
            {
                nexttb = FindName(
                        "Tb" + tb.GetValue(Grid.RowProperty) +
                        "_" + (Convert.ToInt32(tb.GetValue(Grid.ColumnProperty)) + 1)) as TextBox;
                if (nexttb != null)
                {
                    nexttb.Focus();
                    nexttb.SelectionLength = nexttb.Text.Length;
                }
                e.Handled = true;
            }
            else if ((e.Key == Key.Left || e.Key == Key.Back) && tb?.SelectionStart == 0 && tb.SelectionLength == 0)
            {
                nexttb = FindName(
                    "Tb" + tb.GetValue(Grid.RowProperty) +
                    "_" + (Convert.ToInt32(tb.GetValue(Grid.ColumnProperty)) - 1)) as TextBox;
                if (nexttb != null)
                {
                    nexttb.Focus();
                    nexttb.SelectionLength = nexttb.Text.Length;
                }
                e.Handled = true;
            }
            else if (e.Key == Key.Up)
            {
                nexttb = FindName(
                    "Tb" + (Convert.ToInt32(tb.GetValue(Grid.RowProperty).ToString()) - 1) +
                    "_" + tb.GetValue(Grid.ColumnProperty)) as TextBox;
                if (nexttb != null)
                {
                    nexttb.Focus();
                    nexttb.SelectionLength = nexttb.Text.Length;
                }
            }
            else if (e.Key == Key.Down)
            {
                nexttb = FindName(
                    "Tb" + (Convert.ToInt32(tb.GetValue(Grid.RowProperty).ToString()) + 1) +
                    "_" + tb.GetValue(Grid.ColumnProperty)) as TextBox;
                if (nexttb != null)
                {
                    nexttb.Focus();
                    nexttb.SelectionLength = nexttb.Text.Length;
                }
            }
        }
    }
}