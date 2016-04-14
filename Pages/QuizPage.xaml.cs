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

        int currentQuestion = 0;
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
            //if (Properties.Settings.Default.questionNum != Properties.Settings.Default.questions.Count)
            //{
            //    Properties.Settings.Default.questionNum = Properties.Settings.Default.questions.Count;
            //    Properties.Settings.Default.Save();
           // Properties.Settings.Default.questionNum -= 1;
           //Properties.Settings.Default.Save();
            //}
            quizQuestion();
            

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
            int num = Properties.Settings.Default.questionNum;
            questionNum.Text = "Question Number " + (currentQuestion +1) + " of " + (Properties.Settings.Default.questionNum + 1);
            if (num > 1 && currentQuestion <= num)
            {
                question.Text = Properties.Settings.Default.questions[currentQuestion];
                ansA.Content = Properties.Settings.Default.AnsA[currentQuestion];
                ansB.Content = Properties.Settings.Default.AnsB[currentQuestion];
                ansC.Content = Properties.Settings.Default.AnsC[currentQuestion];
                ansD.Content = Properties.Settings.Default.AnsD[currentQuestion];
                rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
                test.Text = Properties.Settings.Default.questions[currentQuestion];
                await Task.Delay(100);
            }
            else
            {
                questionNum.Text = "All Questions Answered!";
                question.Text = "You got " + score + " right out of " + qnum;
                currentQuestion = 0;
            }
        }

        private void start_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            startGame();
        }

        private async void ansD_Click(object sender, RoutedEventArgs e)
        {
            int qnum = Properties.Settings.Default.questions.Count;
            int num = Properties.Settings.Default.questionNum;

            if (num > 1 && currentQuestion <= num)
            {
                rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
                if (rightAns == "d")
                {
                    correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                    correct.Visibility = Visibility.Visible;
                    await Task.Delay(1000);
                    correct.Visibility = Visibility.Collapsed;
                    currentQuestion += 1;
                    score += 1;
                    quizQuestion();
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
                    quizQuestion();
                }
            }
        }

        private async void ansA_Click(object sender, RoutedEventArgs e)
        {
            rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
            if (rightAns == "a")
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
                score += 1;
                quizQuestion();
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
                quizQuestion();
            }
        }

        private async void ansB_Click(object sender, RoutedEventArgs e)
        {

            rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
            if (rightAns == "b")
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
                score += 1;
                quizQuestion();
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
                quizQuestion();
            }
        }

        private async void ansC_Click(object sender, RoutedEventArgs e)
        {

            rightAns = Properties.Settings.Default.CorrectAns[currentQuestion];
            if (rightAns == "c")
            {
                correct.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
                correct.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                correct.Visibility = Visibility.Collapsed;
                currentQuestion += 1;
                score += 1;
                quizQuestion();
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
                quizQuestion();
            }
        }
    }
}
