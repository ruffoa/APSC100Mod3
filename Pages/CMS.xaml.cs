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

    /// <summary>
    /// Interaction logic for CheckBoxRadioButtonSample
    /// </summary>
    public partial class CMS : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxRadioButtonSample" /> class.
        /// </summary>
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
    }
}
