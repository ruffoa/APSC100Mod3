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
            text1.Text = Properties.Settings.Default.info1;
            text2.Text = Properties.Settings.Default.info2;
            text3.Text = Properties.Settings.Default.info3;
            text4.Text = Properties.Settings.Default.info4;
        }
    }
}
