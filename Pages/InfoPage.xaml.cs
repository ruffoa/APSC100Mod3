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

            if (Properties.Settings.Default.infoArray.Count > 5)
            {
                text1.Text = Properties.Settings.Default.infoArray[0];
                text2.Text = Properties.Settings.Default.infoArray[1];
                text3.Text = Properties.Settings.Default.infoArray[2];
                text4.Text = Properties.Settings.Default.infoArray[3];
                text5.Text = Properties.Settings.Default.infoArray[4];
                text6.Text = Properties.Settings.Default.infoArray[5];
                pageTitle.Text = Properties.Settings.Default.infoArray[6];
            }
            else if (Properties.Settings.Default.infoArray.Count > 0)
            {
                text1.Text = "You currently have only " + Properties.Settings.Default.infoArray.Count.ToString() + " out of 6 fields set";
                text2.Text = "Try adding some more content, or click the add default values to quickly test out the platform";
                text3.Text = "Note that clicking this button will give you text that was used for testing this application when designing it, and is not recommended for general use";

            }

        }
    }
}
