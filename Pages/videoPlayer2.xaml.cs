//------------------------------------------------------------------------------
// <copyright file="ButtonSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ButtonSample
    /// </summary>
    public partial class videoplayer2 : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonSample" /> class.
        /// </summary>
        public videoplayer2()
        {
            this.InitializeComponent();
            IsPlaying(false);
            mediaplayer.LoadedBehavior = MediaState.Manual;
            mediaplayer.UnloadedBehavior = MediaState.Stop;
            //mediaplayer.Source = new Uri("Videos/video1.mp4");
            playbutton.IsEnabled = true;
        }

        private void IsPlaying(bool flag)
        {
            playbutton.IsEnabled = flag;
            // btnStop.IsEnabled = flag;
            // btnMoveBack.IsEnabled = flag;
            // btnMoveForward.IsEnabled = flag;
        }

      
        //  private void btnStop_Click(object sender, RoutedEventArgs e)
        //  {
        //      MediaPlayer.Pause();
        //      btnPlay.Content = "Play";
        //      IsPlaying(false);
        //      btnPlay.IsEnabled = true;
        //  }

        //  private void btnMoveBack_Click(object sender, RoutedEventArgs e)
        //  {
        //      MediaPlayer.Position -= TimeSpan.FromSeconds(10);
        //  }

        //  private void btnMoveForward_Click(object sender, RoutedEventArgs e)
        //  {
        //      MediaPlayer.Position += TimeSpan.FromSeconds(10);
        //  }


        private void playbutton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            IsPlaying(true);
            if (playbutton.Content.ToString() == "Play")
            {
                mediaplayer.Play();
                playbutton.Content = "Pause";
                //if (mediaplayer.MediaFailed() += 1)

               
            }
            else
            {
                mediaplayer.Pause();
                playbutton.Content = "Play";
            }
        }

        private void btnOpen_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            mediaplayer.Position = TimeSpan.Zero;
            mediaplayer.Play();
        }
    }
}
