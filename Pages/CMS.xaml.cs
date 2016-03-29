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

            MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            mainWindow.Show();

            //DoOk(this);
            //System.Windows.Window.
          //  this.Close();

            //ControlsBasics.CMS.Close;
            // this.Content = mainWindow;
        }
    }
}
