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
    using System.IO;

    /// <summary>
    /// Interaction logic for CheckBoxRadioButtonSample
    /// </summary>
    public partial class CMS : UserControl
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


       public CMS()
        {
            this.InitializeComponent();

        }

        private void bOpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceFileName = openFileDialog1.FileName.ToString();
            }

        }

        string tempPath;
        string sourceFileName;

        private void chooseOpen_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog2 = new System.Windows.Forms.OpenFileDialog();

            openFileDialog2.Filter = "All Files (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;

            openFileDialog2.Multiselect = true;

            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tempPath = Path.GetDirectoryName(openFileDialog2.FileName);
                System.IO.File.Copy(sourceFileName, "tempPath", true);
            }

        }


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
    }
}
