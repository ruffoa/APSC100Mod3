//------------------------------------------------------------------------------
// <copyright file="ScrollViewerSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System.Windows.Controls;
    using System.Windows;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Media.Imaging;/// <summary>
                                       /// Interaction logic for ScrollViewerSample
                                       /// </summary>
    public partial class QuizPage : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollViewerSample"/> class.
        /// </summary>
        /// 

        int currentQuestion = 1;
        string rightAns = "";
        int score = 0;

        public QuizPage()
        {
            this.InitializeComponent();
            startButton.Background = System.Windows.Media.Brushes.Green;
        }

        private void startGame()
        {
            startButton.Visibility = Visibility.Collapsed;
            gameArea.Visibility = Visibility.Visible;

            

                //for (int i = 0; i < 10; i++)
                //{
                //    test.AppendText(Properties.Settings.Default.AnsA[i]);
                //    test.AppendText(question.Text = Properties.Settings.Default.questions[i]);
                //    test.AppendText(Properties.Settings.Default.AnsA[i]);
                //    test.AppendText(Properties.Settings.Default.AnsB[i]);
                //    test.AppendText(Properties.Settings.Default.AnsC[i]);
                //    test.AppendText(Properties.Settings.Default.AnsD[i]);
                //    test.AppendText(Environment.NewLine);
                //    await Task.Delay(1000);

                //}
            
            // Properties.Settings.Default.Save();

        }

        private async void quizQuestion()
        {
            int qnum = Properties.Settings.Default.questions.Count;
            questionNum.Text = "Question Number " + qnum + " of " + Properties.Settings.Default.questionNum;
            if (qnum > 1 && currentQuestion <= qnum)
            {
                question.Text = Properties.Settings.Default.questions[currentQuestion];
                ansA.Content = Properties.Settings.Default.AnsA[currentQuestion];
                ansB.Content = Properties.Settings.Default.AnsB[currentQuestion];
                ansC.Content = Properties.Settings.Default.AnsC[currentQuestion];
                ansD.Content = Properties.Settings.Default.AnsD[currentQuestion];
                rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
                await Task.Delay(100);
            }
            else
            {
                questionNum.Text = "All Questions Answered!";
                question.Text = "You got " + score + " right out of " + qnum;
            }
        }

        private void start_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            startGame();
        }

        private async void ansD_Click(object sender, RoutedEventArgs e)
        {
            int qnum = Properties.Settings.Default.questions.Count;
            if (qnum > 1 && currentQuestion <= qnum)
            {
                rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
                if (rightAns == "d")
                {
                    correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                    correct.Visibility = Visibility.Visible;
                    await Task.Delay(1000);
                    correct.Visibility = Visibility.Collapsed;
                    currentQuestion += 1;
                }
                else
                {
                    correct.Source = new BitmapImage(new Uri(@"/Images/error.png", UriKind.Relative));
                    pageTitle.Text = "Correct Answer was: " + rightAns;
                    correct.Visibility = Visibility.Visible;
                    await Task.Delay(1000);
                    correct.Visibility = Visibility.Collapsed;
                    currentQuestion += 1;
                    pageTitle.Text = "Quiz Game";
                }
            }
        }

        private async void ansA_Click(object sender, RoutedEventArgs e)
        {
            rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
            if (rightAns == "d")
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
            }
            else
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/error.png", UriKind.Relative));
                pageTitle.Text = "Correct Answer was: " + rightAns;
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
                pageTitle.Text = "Quiz Game";
            }
        }

        private async void ansB_Click(object sender, RoutedEventArgs e)
        {

            rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
            if (rightAns == "d")
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
            }
            else
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/error.png", UriKind.Relative));
                pageTitle.Text = "Correct Answer was: " + rightAns;
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
                pageTitle.Text = "Quiz Game";
            }
        }

        private async void ansC_Click(object sender, RoutedEventArgs e)
        {

            rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
            if (rightAns == "d")
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
            }
            else
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/error.png", UriKind.Relative));
                pageTitle.Text = "Correct Answer was: " + rightAns;
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
                pageTitle.Text = "Quiz Game";
            }
        }
    }
}
