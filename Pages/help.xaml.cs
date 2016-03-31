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
    using Microsoft.Kinect.Wpf.Controls;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Input;/// <summary>
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
        bool hoverCheck = false;
        int helpID = 1;
        int maxPage = 4;

        public Help()
        {
            this.InitializeComponent();
            KinectRegion.SetKinectRegion(this, kinectRegion);

            App app = ((App)Application.Current);
            app.KinectRegion = kinectRegion;

            // Use the default sensor
            this.kinectRegion.KinectSensor = KinectSensor.GetDefault();

            //// Add in display content
            

            

            MediaPlayer.LoadedBehavior = MediaState.Manual;
            MediaPlayer.Play();
            MediaPlayer.MediaEnded += new RoutedEventHandler(MediaPlayer_OnMediaEnded);
            this.Loaded += KinectPointerPointSample_Loaded;

        }

        private async void delay(int msec)
        {
            //await Task.Delay(msec);
        }

        void KinectPointerPointSample_Loaded(object sender, RoutedEventArgs e)
        {
            // Listen to Kinect pointer events
            KinectCoreWindow kinectCoreWindow = KinectCoreWindow.GetForCurrentThread();
            kinectCoreWindow.PointerMoved += kinectCoreWindow_PointerMoved;
        }
        private SolidColorBrush yellowBrush = Brushes.Yellow;
        private TimeSpan lastTime;
        private SolidColorBrush greenBrush = Brushes.Green;
        private const double DotHeight = 60;
        private const double DotWidth = 60;
        private SolidColorBrush blackBrush = Brushes.Black;


        private void kinectCoreWindow_PointerMoved(object sender, KinectPointerEventArgs args)
        {
            KinectPointerPoint kinectPointerPoint = args.CurrentPoint;
            if (lastTime == TimeSpan.Zero || lastTime != kinectPointerPoint.Properties.BodyTimeCounter)
            {
                lastTime = kinectPointerPoint.Properties.BodyTimeCounter;
                mainScreen.Children.Clear();
            }

            RenderPointer(kinectPointerPoint.Properties.IsEngaged,
                kinectPointerPoint.Position,
                kinectPointerPoint.Properties.UnclampedPosition,
                kinectPointerPoint.Properties.HandReachExtent,
                kinectPointerPoint.Properties.BodyTimeCounter,
                kinectPointerPoint.Properties.BodyTrackingId,
                kinectPointerPoint.Properties.HandType);
        }
        private void RenderPointer(
            bool isEngaged,
            PointF position,
            PointF unclampedPosition,
            float handReachExtent,
            TimeSpan timeCounter,
            ulong trackingId,
            HandType handType)

        {
            StackPanel cursor = null;
            if (cursor == null)
            {
                cursor = new StackPanel();
                mainScreen.Children.Add(cursor);
            }

            cursor.Children.Clear();
            var ellipseColor = isEngaged ? greenBrush : yellowBrush;

            StackPanel sp = new StackPanel()
            {
                Margin = new Thickness(-5, -5, 0, 0),
                Orientation = Orientation.Horizontal
            };
            sp.Children.Add(new Ellipse()
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                Height = DotHeight,
                Width = DotWidth,
                Margin = new Thickness(5),
                Fill = ellipseColor
            });
            cursor.Children.Add(sp);

           
            Canvas.SetLeft(cursor, position.X * mainScreen.ActualWidth - DotWidth / 2);
            Canvas.SetTop(cursor, position.Y * mainScreen.ActualHeight - DotHeight / 2);

            Ellipse unclampedCursor = new Ellipse()
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                Height = 60,
                Width = 60,
                StrokeThickness = 5,
                Stroke = blackBrush
            };

            mainScreen.Children.Add(unclampedCursor);
            Canvas.SetLeft(unclampedCursor, unclampedPosition.X * mainScreen.ActualWidth - DotWidth / 2);
            Canvas.SetTop(unclampedCursor, unclampedPosition.Y * mainScreen.ActualHeight - DotHeight / 2);
            if (isEngaged == true && hoverCheck == false)
            {
                hoverCheck = true;
                mainScreen.Visibility = Visibility.Collapsed;
                check.Visibility = Visibility.Visible;
                delay(1000);
               // next_Click(sender, e);
                next.Click += next_Click;

            }
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
                MainWindow.inHelp = false;
                MainWindow.openHelp = false;
                MainWindow.usertimer.Enabled = true;

                ControlsBasics.MainWindow.CloseWindow();

            }

            MainWindow.inHelp = false;
            MainWindow.openHelp = false;
           // MainWindow.detectedUsers = 0;
           // MainWindow.nusers = 0;
           MainWindow.usertimer.Enabled = true;
            ControlsBasics.MainWindow.CloseWindow();
           
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
