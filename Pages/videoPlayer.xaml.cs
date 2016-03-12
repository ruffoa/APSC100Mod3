namespace Microsoft.Samples.Kinect.ControlsBasics
{
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
        }
        private void IsPlaying(bool flag)
        {
            playbutton.IsEnabled = flag;
            // btnStop.IsEnabled = flag;
            // btnMoveBack.IsEnabled = flag;
            // btnMoveForward.IsEnabled = flag;
        }
    }
}