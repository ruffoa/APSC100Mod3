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
    public partial class TestPage : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollViewerSample"/> class.
        /// </summary>
        public TestPage()
        {
            this.InitializeComponent();

        }
        

        private void Browser_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Browser.Navigate("http://www.google.com");
        }
    }
}
