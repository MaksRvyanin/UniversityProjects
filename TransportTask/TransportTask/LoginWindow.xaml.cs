using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace vector
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        DispatcherTimer t = new DispatcherTimer() {Interval = TimeSpan.FromMilliseconds(50), IsEnabled = true};
        public LoginWindow()
        {
            InitializeComponent();
            t.Tick +=(sender, args) =>
            {
                labelLang.Content = InputLanguageManager.Current.CurrentInputLanguage.TwoLetterISOLanguageName.ToUpper();
                labelCaps.Visibility = Console.CapsLock ? Visibility.Visible : Visibility.Hidden;
            };
        }

        private bool enter = false;

        private void ButtonCommonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private string login = "admin";
        private string password = "admin";
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TboxLogin.Text == login && TboxPswd.Password == password)
            {
                enter = true;
                Close();
            }
            else
            {
                (FindResource("StoryboardError") as Storyboard)?.Begin();
                ErrorBlock.Text = "Неверный логин или пароль";
            }
        }
        
        private void TboxLogin_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                TboxPswd.Focus();
        }
        private void TboxPswd_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                BtnLogin_Click(sender, e);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TboxLogin.Focus();
            labelLang.Content = InputLanguageManager.Current.CurrentInputLanguage.TwoLetterISOLanguageName.ToUpper();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (enter)
                t.Stop();
            else
                Environment.Exit(0);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}