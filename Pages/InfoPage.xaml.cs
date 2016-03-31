//------------------------------------------------------------------------------
// <copyright file="ScrollViewerSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ScrollViewerSample
    /// </summary>
    public partial class InfoPage : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPage"/> class.
        /// </summary>
        public InfoPage()
        {
            this.InitializeComponent();
            textUpdate();
        }

        public void textUpdate()
        {
            text2.Text = "Formed in 1897, the Engineering Society of Queen’s University is one of the oldest representative bodies for engineering students in Canada and continues to be a leader in student initiatives.";
            text1.Text = "DNA is a vital part of the human species";
            text3.Text = "Lorem Ipsum.....";
            text4.Text = "this is more generic text";
        }
    }
}
