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
    using System.Windows.Navigation;
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Interaction logic for CheckBoxRadioButtonSample
    /// </summary>
    public partial class CMS : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxRadioButtonSample" /> class.
        /// </summary>
        /// 
        //  private MainWindow MainWindow;

        //  public CMS(MainWindow mainWindow)
        //  {
        //      InitializeComponent();

        //      this.MainWindow = mainWindow;

        // Other constructor stuff
        //  }
        int questionNumber = 0;
        string selAns = "";

        public CMS()
        {
            this.InitializeComponent();
            qInfo.Text = "Editing Question Number " + (questionNumber + 1) + " of " + Properties.Settings.Default.questionNum;
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

       
        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            //   NavigationService nav = NavigationService.GetNavigationService(this);
            // nav.Navigate(new Uri("xamlFeedbackPage.xaml", UriKind.RelativeOrAbsolute));

            // MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            
            if (MainWindow.winCount() == 3)
            {
                MainWindow nmain = new MainWindow();
                nmain.Show();
                ControlsBasics.MainWindow.CloseWindow();

            }


            ControlsBasics.MainWindow.CloseWindow();
           
        }

        private void Close()
        {
            
           
        }

        private void UserControl_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                //MessageBox.Show("key detected");

                // MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();

                //MainWindow.winCount();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                if (MainWindow.winCount() == 3)
                {
                    MainWindow nmain = new MainWindow();
                    nmain.Show();
                    ControlsBasics.MainWindow.CloseWindow();

                }


                ControlsBasics.MainWindow.CloseWindow();
            }


        }

        //private void questionChange_Click(object sender, RoutedEventArgs e)
        //{

        //    //IList<string> a = new List<string>();
        //    //a.Add(questionText.Text);
        //    //Properties.Settings.Default.questions = a;

        //    Properties.Settings.Default.questions.Add(questionText.Text);
        //    Properties.Settings.Default.Save();
        //}

        //private void ansaChange_Click(object sender, RoutedEventArgs e)
        //{
        //    Properties.Settings.Default.AnsA.Add(ansA.Text);
        //    Properties.Settings.Default.Save();
        //}

        //private void ansbChange_Click(object sender, RoutedEventArgs e)
        //{
        //    Properties.Settings.Default.AnsB.Add(ansB.Text);
        //    Properties.Settings.Default.Save();
        //}

        //private void anscChange_Click(object sender, RoutedEventArgs e)
        //{
        //    Properties.Settings.Default.AnsC.Add(ansC.Text);
        //    Properties.Settings.Default.Save();
        //}

        private void ansdChange_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.questions.Add(questionText.Text);
            Properties.Settings.Default.AnsA.Add(ansA.Text);
            Properties.Settings.Default.AnsB.Add(ansB.Text);
            Properties.Settings.Default.AnsC.Add(ansC.Text);
            Properties.Settings.Default.AnsD.Add(ansD.Text);
            Properties.Settings.Default.CorrectAns.Add(selAns);
            Properties.Settings.Default.Save();

        }

        private void addQuestion_Click(object sender, RoutedEventArgs e)
        {
            questionNumber += 1;
            Properties.Settings.Default.questionNum += 1;
            Properties.Settings.Default.Save();
            qInfo.Text = "Editing Question Number " + (questionNumber + 1) + " of " + Properties.Settings.Default.questionNum;
            ansA.Text = "";
            ansB.Text = "";
            ansC.Text = "";
            ansD.Text = "";
            questionText.Text = "";
            qSave.IsEnabled = true;
            ansA.IsEnabled = true;
            ansB.IsEnabled = true;
            ansC.IsEnabled = true;
            ansD.IsEnabled = true;
            questionText.IsEnabled = true;

        }

        private void deleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (questionNumber > 0)
            {
                Properties.Settings.Default.questions.RemoveAt(questionNumber);
                Properties.Settings.Default.AnsA.RemoveAt(questionNumber);
                Properties.Settings.Default.AnsB.RemoveAt(questionNumber);
                Properties.Settings.Default.AnsC.RemoveAt(questionNumber);
                Properties.Settings.Default.AnsD.RemoveAt(questionNumber);
                questionNumber -= 1;
                Properties.Settings.Default.questionNum -= 1;
                Properties.Settings.Default.Save();
                qInfo.Text = "Editing Question Number " + (questionNumber + 1) + " of " + Properties.Settings.Default.questionNum;
                ansA.Text = "";
                ansB.Text = "";
                ansC.Text = "";
                ansD.Text = "";
                questionText.Text = "";
                qSave.IsEnabled = true;
                ansA.IsEnabled = true;
                ansB.IsEnabled = true;
                ansC.IsEnabled = true;
                ansD.IsEnabled = true;
                questionText.IsEnabled = true;
            }
        }

        

        private void QuestionMode_Click(object sender, RoutedEventArgs e)
        {
            fileChange.Visibility = Visibility.Collapsed;
            quizChange.Visibility = Visibility.Visible;
            qInfo.Text = "Editing Question Number " + questionNumber + " of " + Properties.Settings.Default.questionNum;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void comboBox_DropDownOpened(object sender, EventArgs e)
        {
            qSelector.Items.Clear();

            if (Properties.Settings.Default.questionNum > 0)
            {
                for (int i = 0; i < Properties.Settings.Default.questionNum; i++)
                qSelector.Items.Add("Question" + i);
            }
        }

        private void qSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            questionNumber = qSelector.SelectedIndex + 1;
            qInfo.Text = "Editing Question Number " + questionNumber + " of " + Properties.Settings.Default.questionNum;
             
            ansA.Text = Properties.Settings.Default.AnsA[questionNumber];
            ansB.Text = Properties.Settings.Default.AnsB[questionNumber];
            ansC.Text = Properties.Settings.Default.AnsC[questionNumber];
            ansD.Text = Properties.Settings.Default.AnsD[questionNumber];
            questionText.Text = Properties.Settings.Default.questions[questionNumber];
            qSave.IsEnabled = false;
            ansA.IsEnabled = false;
            ansB.IsEnabled = false;
            ansC.IsEnabled = false;
            ansD.IsEnabled = false;
            questionText.IsEnabled = false;

        }

        private void selA_Checked(object sender, RoutedEventArgs e)
        {
            selAns = "a";
        }

        private void selB_Checked(object sender, RoutedEventArgs e)
        {
            selAns = "b";
        }

        private void selC_Checked(object sender, RoutedEventArgs e)
        {
            selAns = "c";
        }

        private void selD_Checked(object sender, RoutedEventArgs e)
        {
            selAns = "d";
        }

        private void fileMode_Click(object sender, RoutedEventArgs e)
        {
            fileChange.Visibility = Visibility.Visible;
            quizChange.Visibility = Visibility.Collapsed;
        }
    }
}
