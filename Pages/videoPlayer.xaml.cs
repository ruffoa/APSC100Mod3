﻿//------------------------------------------------------------------------------
// <copyright file="ButtonSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ButtonSample
    /// </summary>
    public partial class videoplayer : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonSample" /> class.
        /// </summary>
        public videoplayer()
        {
            this.InitializeComponent();
            IsPlaying(false);
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
    }
}