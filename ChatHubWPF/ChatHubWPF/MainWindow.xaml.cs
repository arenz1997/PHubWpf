using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ChatHubWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(SignUpNameBox.Text, SignUpUsernameBox.Text);
            window1.Show();
            this.Close();
            //pti kpnenw login service-in
        }

        private void RegistrationButtonClick(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(SignUpNameBox.Text, SignUpUsernameBox.Text);
            window1.Show();
            this.Close();
            //pti kpnenq registration service-in
        }

        private void SignInUsernameBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (SignInUsernameBox.Text == "Username") SignInUsernameBox.Text = "";
        }
        private void SignInUsernameBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SignInUsernameBox.Text == "Username") SignInUsernameBox.Text = "";
        }
        private void SignInPasswordBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (SignInPasswordBox.Password == "password") SignInPasswordBox.Password = "";
        }
        
        private void SignInPasswordBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SignInPasswordBox.Password == "password") SignInPasswordBox.Password = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpNameBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SignUpNameBox.Text == "Name") SignUpNameBox.Text = "";
        }

        private void SignUpNameBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (SignUpNameBox.Text == "Name") SignUpNameBox.Text = "";
        }
        /// <summary>
        /// /////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpEmailBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SignUpEmailBox.Text == "Email") SignUpEmailBox.Text = "";
        }

        private void SignUpEmailBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (SignUpEmailBox.Text == "Email") SignUpEmailBox.Text = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpUsernameBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (SignUpUsernameBox.Text == "Username") SignUpUsernameBox.Text = "";
        }

        private void SignUpUsernameBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SignUpUsernameBox.Text == "Username") SignUpUsernameBox.Text = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpPasswordBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (SignUpPasswordBox.Text == "password") SignUpPasswordBox.Text = "";
        }

        private void SignUpPasswordBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (SignUpPasswordBox.Password == "password") SignUpPasswordBox.Password = "";
        }

        private void SignInUsernameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SignInUsernameBox.Text == "") SignInUsernameBox.Text = "Username";
        }

        private void SignInPasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SignInPasswordBox.Password == "") SignInPasswordBox.Password = "password";
        }


        private void SignUpEmailBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SignUpEmailBox.Text == "") SignUpEmailBox.Text = "Email";
        }

        private void SignUpUsernameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SignUpUsernameBox.Text == "") SignUpUsernameBox.Text = "Username";
        }

        private void SignUpPasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SignUpPasswordBox.Password == "") SignUpPasswordBox.Password = "password";
        }

        private void SignUpNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SignUpNameBox.Text == "") SignUpNameBox.Text = "Name";
        }
    }
}