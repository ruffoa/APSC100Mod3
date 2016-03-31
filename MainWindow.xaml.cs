//------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Wpf.Controls;
    using Microsoft.Samples.Kinect.ControlsBasics.DataModel;
    using System.Windows.Input;
    using System.Timers;
    using System.Collections;
    using System.IO;    /// <summary>
                        /// Interaction logic for MainWindow
                        /// </summary>
    public partial class MainWindow
    {
        public static MainWindow m_Singleton = new ControlsBasics.MainWindow();
        //public static string password = "ecei";
        // password = ControlsBasics.Properties.Settings.Default.password
        public static string password = Properties.Settings.Default.password;

        public static bool user = false;
        public static System.Timers.Timer aTimer = new System.Timers.Timer();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class. 
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            KinectRegion.SetKinectRegion(this, kinectRegion);

            App app = ((App)Application.Current);
            app.KinectRegion = kinectRegion;

            // Use the default sensor
            this.kinectRegion.KinectSensor = KinectSensor.GetDefault();

            //// Add in display content
            var sampleDataSource = SampleDataSource.GetGroup("Group-1");
            this.itemsControl.ItemsSource = sampleDataSource;

            checkActive();
        }

        /// <summary>
        /// Handle a button click from the wrap panel.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.OriginalSource;
            SampleDataItem sampleDataItem = button.DataContext as SampleDataItem;

            if (sampleDataItem != null && sampleDataItem.NavigationPage != null)
            {
                backButton.Visibility = System.Windows.Visibility.Visible;
                navigationRegion.Content = Activator.CreateInstance(sampleDataItem.NavigationPage);
            }
            else
            {
                var selectionDisplay = new SelectionDisplay(button.Content as string);
                this.kinectRegionGrid.Children.Add(selectionDisplay);

                // Selection dialog covers the entire interact-able area, so the current press interaction
                // should be completed. Otherwise hover capture will allow the button to be clicked again within
                // the same interaction (even whilst no longer visible).
                selectionDisplay.Focus();

                // Since the selection dialog covers the entire interact-able area, we should also complete
                // the current interaction of all other pointers.  This prevents other users interacting with elements
                // that are no longer visible.
                this.kinectRegion.InputPointerManager.CompleteGestures();

                e.Handled = true;
            }
        }

        public void checkActive()
        {
            if (kinectRegion.EngagedBodyTrackingIds.Count == 0)
            {

            }
            else
            {
                Help mynewPage = new Help(); //newPage is the name of the newPage.xaml file

                this.Content = mynewPage;
            }
        }
       
        /// <summary>
        /// Handle the back button click.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void GoBack(object sender, RoutedEventArgs e)
        {
            backButton.Visibility = System.Windows.Visibility.Hidden;
            navigationRegion.Content = this.kinectRegionGrid;
        }


        private void ControlsBasicsWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Home)
            {
                if (user == true)
                {
                    CMS mynewPage = new CMS(); //newPage is the name of the newPage.xaml file

                    this.Content = mynewPage;
                }
                // MessageBox.Show("key detected");

                else
                {
                    Login mynewPage = new Login(); //newPage is the name of the newPage.xaml file

                    this.Content = mynewPage;


                }


            }

            if (e.Key == System.Windows.Input.Key.End)
            {
                // MessageBox.Show("key detected");
                Help mynewPage = new Help(); //newPage is the name of the newPage.xaml file

                this.Content = mynewPage;
            }

        }

        public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = null;

            foreach (Window window in Application.Current.Windows)
            {
                Type type = typeof(MainWindow);
                if (window != null && window.DependencyObjectType.Name == type.Name)
                {
                    mainWindow = (MainWindow)window;
                    if (mainWindow != null)
                    {
                        break;
                    }
                }
            }


            return mainWindow;

        }



        public static MainWindow CloseWindow()
        {

            MainWindow nll = null;
            MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            //mainWindow.Close();

            var winctr = Application.Current.Windows.Count;
            string myString = winctr.ToString();

            //for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
            for (int intCounter = 0; intCounter <= App.Current.Windows.Count - 1; intCounter++)
            {
                App.Current.Windows[intCounter].Close();
                string winID = intCounter.ToString();

                // MessageBox.Show("window closed" + winID);
            }

            //MessageBox.Show(myString);


            return nll;
        }

        public static MainWindow CloseAllButMain()
        {

            MainWindow nll = null;
            MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            //mainWindow.Close();

            var winctr = Application.Current.Windows.Count;
            string myString = winctr.ToString();

            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 1; intCounter--)
            //for (int intCounter = 0; intCounter <= App.Current.Windows.Count - 1; intCounter++)
            {
                App.Current.Windows[intCounter].Close();
                string winID = intCounter.ToString();

                // MessageBox.Show("window closed" + winID);
            }

            //MessageBox.Show(myString);


            return nll;
        }

        public static void LoginCMS()
        {
            CloseAllButMain();

            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 300000;
            aTimer.Enabled = true;

            var key = Key.Home;                    // Key to send
            var target = Keyboard.FocusedElement;    // Target element
            var routedEvent = Keyboard.KeyDownEvent; // Event to send

            target.RaiseEvent(new System.Windows.Input.KeyEventArgs(Keyboard.PrimaryDevice,
  System.Windows.PresentationSource.FromVisual((System.Windows.Media.Visual)target), 0, key)
            { RoutedEvent = routedEvent });

        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            user = false;
            aTimer.Enabled = false;
        }

        private void openCMS()
        {
            if (user == true)
            {
                CMS cms1 = new CMS(); //newPage is the name of the newPage.xaml file

                this.Content = cms1;
            }
        }

        public static int winCount()
        {
            var winctr = Application.Current.Windows.Count;
            string myString = winctr.ToString();
            //MessageBox.Show(myString);
            return winctr;
        }

    }
    }
