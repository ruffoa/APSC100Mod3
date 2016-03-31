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
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    /// <summary>
    /// Interaction logic for CheckBoxRadioButtonSample
    /// </summary>
    public partial class Help : UserControl
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

        int helpID = 1;
        int maxPage = 4;

        public Help()
        {
            this.InitializeComponent();
            MediaPlayer.LoadedBehavior = MediaState.Manual;
            MediaPlayer.Play();
            MediaPlayer.MediaEnded += new RoutedEventHandler(MediaPlayer_OnMediaEnded);


        }



        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MediaPlayer_OnMediaEnded(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Position = TimeSpan.Zero;
            MediaPlayer.Play();
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

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (helpID < maxPage)
            {
                helpID += 1;
            }
            else
            {
                helpID = 1;
                next.Content = "Next Instruction";
                next.Background = System.Windows.Media.Brushes.Green;
            }
                if (helpID == 1)
            {
                MediaPlayer.Source = new Uri(@"Videos/guide1.mp4", UriKind.Relative);
                scrollHelp.Text = "The following guide will help you learn how to use the reposnsive Kinect display.  Hold out your hand towards the screen in order to be detected by the Kinect sensor.";
                scrollHelp.AppendText(Environment.NewLine);
                scrollHelp.AppendText(Environment.NewLine);
                scrollHelp.AppendText("A hand cursor will apear on screen when you are recognized.  This process may take a few seconds.");

            }
           
            if (helpID == 2)
            {
                scrollHelp.Text = "To select an item, push it and then pull back";
                MediaPlayer.Source = new Uri(@"Videos/guide3a.mp4",UriKind.Relative);

            }
            if (helpID == 3)
            {
                scrollHelp.Text = "To scroll in menus, hold out your hand and let your pointer appear on screen.  Then clench your hand and make a fist, and once the on screen avatar does the same thing, move your arm across the screen as if your were grabbing the screen and pulling it.";
                MediaPlayer.Source = new Uri(@"Videos/guide4.mp4", UriKind.Relative);

            }
            if (helpID == 4)
            {
                scrollHelp.Text = "To zoom in and out on pictures (when allowed), grab the picture with a fist, and then pull the screen towards you.  To zoom out, push the screen away.";
                MediaPlayer.Source = new Uri(@"Videos/guide5.mp4", UriKind.Relative);
                next.Content = "Start Over";
                next.Background = System.Windows.Media.Brushes.Red;

            }

        }

        private void hoverTest_MouseMove(object sender, MouseEventArgs e)
        {
           // helpID += 1;
            hoverTest.Visibility = Visibility.Collapsed;
            next_Click(sender, e);
        }
    }
}
