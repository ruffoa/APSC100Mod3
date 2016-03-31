//------------------------------------------------------------------------------
// <copyright file="CheckBoxRadioButtonSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System.Windows.Controls;
    using System.Windows;
    using Win32;
    using System.Windows.Navigation;
    using System;
    using System.Threading;
    using System.Windows.Media.Imaging;
    using System.Threading.Tasks;/// <summary>
                                 /// Interaction logic for CheckBoxRadioButtonSample
                                 /// </summary>
    public partial class Login : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxRadioButtonSample" /> class.
        /// </summary>
        /// 
        //  private MainWindow MainWindow;

        //  public CMS(MainWindow mainWindow)
        //  {
        //      InitializeComponent();

        //      this.MainWindow = mainWindow;

        // Other constructor stuff
        //  }
        bool changePass = false;

       public Login()
        {
            this.InitializeComponent();

        }

        private void bOpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            bool? userClickedOK = openFileDialog1.ShowDialog();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        void DoOk(Window CMS)
        {
            // < !--Your Code-- >
         //win.DialogResult = true;
            CMS.Close();
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            //   NavigationService nav = NavigationService.GetNavigationService(this);
            // nav.Navigate(new Uri("xamlFeedbackPage.xaml", UriKind.RelativeOrAbsolute));

            // MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            
            if (MainWindow.winCount() == 3)
            {
                MainWindow nmain = new MainWindow();
                nmain.Show();
                ControlsBasics.MainWindow.CloseWindow();

            }


            ControlsBasics.MainWindow.CloseWindow();
           
        }

        private void Close()
        {
            
           
        }

        private void UserControl_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                //MessageBox.Show("key detected");

                // MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();

                //MainWindow.winCount();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                if (MainWindow.winCount() == 3)
                {
                    MainWindow nmain = new MainWindow();
                    nmain.Show();
                    ControlsBasics.MainWindow.CloseWindow();

                }


                ControlsBasics.MainWindow.CloseWindow();
            }


        }

        private async void login_click(object sender, RoutedEventArgs e)
        {
            if (passBox.Text == MainWindow.password)
            {
                MainWindow.user = true;
                loginButton.Background = System.Windows.Media.Brushes.Green;
                status.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                textStatus.Text = "Login Successful!";
                passBox.Text = "";
              
                await Task.Delay(1000);

                MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
                mainWindow.Show();
                ControlsBasics.MainWindow.LoginCMS();
                
            }
            else
            {
                loginButton.Background = System.Windows.Media.Brushes.Red;
                status.Source = new BitmapImage(new Uri(@"/Images/error.png", UriKind.Relative));
                textStatus.Text = "Wrong Password, Try Again";
                passBox.Text = "";
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            mainWindow.Show();

            ControlsBasics.MainWindow.CloseAllButMain();

        }

        private async void passChange_Click(object sender, RoutedEventArgs e)
        {
            loginButton.Background = System.Windows.Media.Brushes.Gray;

            if (changePass == true)
            {
                MainWindow.password = passBox.Text;
                Properties.Settings.Default.password = passBox.Text;
                Properties.Settings.Default.Save();
                status.Source = new BitmapImage(new Uri(@"/Images/list.png", UriKind.Relative));
                passChange.Background = System.Windows.Media.Brushes.Green;
                textStatus.Text = "Password Successfully Changed to " + MainWindow.password + "!";
                await Task.Delay(1000);
                textStatus.Text = "Password Successfully Changed";
                passChange.Background = System.Windows.Media.Brushes.LightGray;
                loginButton.Background = System.Windows.Media.Brushes.LightGray;
                passBox.Text = "";
                changePass = false;
            }
            else
            {
                if (passBox.Text == MainWindow.password)
                {
                    changePass = true;
                    passBox.Text = "";
                    textStatus.Text = "Please Enter the New Password";
                    status.Source = new BitmapImage(new Uri(@"/Images/admin.png", UriKind.Relative));
                    passChange.Background = System.Windows.Media.Brushes.Orange;
                }
                else
                {
                    textStatus.Text = "Please type in old password";
                    passBox.Text = "";
                    passChange.Background = System.Windows.Media.Brushes.Red;
                }
            }

        }

        private void passBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)

                if (changePass == true)
                {
                    passChange_Click(sender, e);
                }
            else
                {
                login_click(sender, e);
                }

        }
    }
}
