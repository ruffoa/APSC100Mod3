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
    using System.Threading.Tasks;
    using System.Windows.Media.Imaging;/// <summary>
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
        bool inEdit = false;
        int infoNum = 0;

        public CMS()
        {
            this.InitializeComponent();
            qInfo.Text = "Editing Question Number " + (questionNumber + 1) + " of " + Properties.Settings.Default.questionNum;
        }


        string tempPath;
        string sourceFileName;

        private void bOpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceFileName = openFileDialog1.FileName.ToString();
                textBox1.Text = openFileDialog1.FileName;
            }

        }
        private void editBut_Click(object sender, RoutedEventArgs e)
        {
            var confirmResult = System.Windows.Forms.MessageBox.Show("Do you want to replace this file",
                                     "",
                                     System.Windows.Forms.MessageBoxButtons.YesNo);
            if (confirmResult == System.Windows.Forms.DialogResult.Yes)
            {
                System.IO.File.Copy(sourceFileName, tempPath, true);
            }
            else
            {
            }

        }

        private void chooseOpen_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog2 = new System.Windows.Forms.OpenFileDialog();

            openFileDialog2.Filter = "All Files (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;

            openFileDialog2.Multiselect = true;

            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;
                tempPath = openFileDialog2.FileName; ;
            }


        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            //   NavigationService nav = NavigationService.GetNavigationService(this);
            // nav.Navigate(new Uri("xamlFeedbackPage.xaml", UriKind.RelativeOrAbsolute));

            if (inEdit == true)
            {
                Properties.Settings.Default.questionNum -= 1;
                Properties.Settings.Default.Save();
            }

            // MainWindow mainWindow = ControlsBasics.MainWindow.GetMainWindow();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            // await Task.Delay(1000);

            if (MainWindow.winCount() == 3)
            {
                MainWindow nmain = new MainWindow();
                nmain.Show();
                ControlsBasics.MainWindow.CloseWindow();
                //await Task.Delay(1000);
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
                if (inEdit == true)
                {
                    Properties.Settings.Default.questionNum -= 1;
                    Properties.Settings.Default.Save();
                }
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
            inEdit = false;
        }

        private void addQuestion_Click(object sender, RoutedEventArgs e)
        {
            questionNumber += 1;
            Properties.Settings.Default.questionNum += 1;
            Properties.Settings.Default.Save();
            qInfo.Text = "Editing Question Number " + (questionNumber) + " of " + Properties.Settings.Default.questionNum;
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
            inEdit = true;
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
                Properties.Settings.Default.CorrectAns.RemoveAt(questionNumber);
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
            infoChange.Visibility = Visibility.Collapsed;
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
                for (int i = 0; i <= Properties.Settings.Default.questionNum; i++)
                    qSelector.Items.Add("Question" + i);
            }
        }

        private void qSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            questionNumber = qSelector.SelectedIndex;
            if (questionNumber < 0)
            {
                questionNumber = 0;
            }
            qInfo.Text = "Editing Question Number " + questionNumber + " of " + Properties.Settings.Default.questionNum;

            ansA.Text = Properties.Settings.Default.AnsA[questionNumber];
            ansB.Text = Properties.Settings.Default.AnsB[questionNumber];
            ansC.Text = Properties.Settings.Default.AnsC[questionNumber];
            ansD.Text = Properties.Settings.Default.AnsD[questionNumber];
            questionText.Text = Properties.Settings.Default.questions[questionNumber];
            selAns = Properties.Settings.Default.CorrectAns[questionNumber];
            if (selAns == "a")
            {
                selA.IsChecked = true;
            }
            else if (selAns == "b")
                selB.IsChecked = true;
            else if (selAns == "c")
                selC.IsChecked = true;
            else if (selAns == "d")
                selD.IsChecked = true;

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
            infoChange.Visibility = Visibility.Collapsed;
        }


        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.info1 = textBox.Text;
        }

        private void infoChange_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = Properties.Settings.Default.info1;
            textBox2.Text = Properties.Settings.Default.info2;
            //textBox3.Text = Properties.Settings.Default.info3;
            //textBox4.Text = Properties.Settings.Default.info4;  
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.info2 = textBox.Text;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.info3 = textBox.Text;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.info4 = textBox.Text;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            fileChange.Visibility = Visibility.Visible;
            quizChange.Visibility = Visibility.Collapsed;
            infoChange.Visibility = Visibility.Collapsed;
        }

        private void goBack_Click2(object sender, RoutedEventArgs e)
        {
            fileChange.Visibility = Visibility.Collapsed;
            quizChange.Visibility = Visibility.Collapsed;
            infoChange.Visibility = Visibility.Visible;
        }


        private void clearAll_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.questions.Clear();
            Properties.Settings.Default.AnsA.Clear();
            Properties.Settings.Default.AnsB.Clear();
            Properties.Settings.Default.AnsC.Clear();
            Properties.Settings.Default.AnsD.Clear();
            Properties.Settings.Default.CorrectAns.Clear();
            Properties.Settings.Default.questionNum = 0;

        }

        private void textSelector_DropDownOpened(object sender, EventArgs e)
        {
            textSelector.Items.Clear();

            if (inEdit == true)
            {
                Properties.Settings.Default.questionNum -= 1;
                Properties.Settings.Default.Save();
                inEdit = false;
            }

            if (Properties.Settings.Default.infoArray.Count > 0)
            {
                infoBox.Text = Properties.Settings.Default.infoArray.Count + " Entries Found";
                for (int i = 0; i < Properties.Settings.Default.infoArray.Count; i++)
                    if (i == 6)
                    {
                        textSelector.Items.Add("Page Title");
                    }
                    else
                    {
                        string description = "";
                        if (Properties.Settings.Default.infoArray[i].Length < 15 && Properties.Settings.Default.infoArray[i].Length > 0)
                        {
                            description = !String.IsNullOrWhiteSpace(Properties.Settings.Default.infoArray[i]) 
    ? Properties.Settings.Default.infoArray[i].Substring(0, Properties.Settings.Default.infoArray[i].Length) : Properties.Settings.Default.infoArray[i];
                        }
                        else {
                            description = !String.IsNullOrWhiteSpace(Properties.Settings.Default.infoArray[i]) && Properties.Settings.Default.infoArray[i].Length >= 15
        ? Properties.Settings.Default.infoArray[i].Substring(0, 15) : Properties.Settings.Default.infoArray[i];
                        }
                        
                        textSelector.Items.Add("Field" + i + ": " + description); // + " : " + StringExtensions.TruncateLongString(Properties.Settings.Default.infoArray[i], 15));
                    }
             }
        }

       

        private void textSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            infoNum = textSelector.SelectedIndex;
            if (infoNum < 0)
            {
                infoNum = 0;
            }

            infoBox.Text = Properties.Settings.Default.infoArray[infoNum];

        }

        private async void saveInfo_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.infoArray[infoNum] = infoBox.Text;
            Properties.Settings.Default.Save();

           // saveInfo.Background = System.Windows.Media.Brushes.Green;
            //check.Source = new BitmapImage(new Uri(@"/Images/check.png", UriKind.Relative));
            check.Visibility = Visibility.Visible;
            await Task.Delay(500);
            check.Visibility = Visibility.Collapsed;

        }

        private void addInfo_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.infoArray.Clear();
            Properties.Settings.Default.infoArray.Add(Properties.Settings.Default.info1);
            Properties.Settings.Default.infoArray.Add(Properties.Settings.Default.info2);
            Properties.Settings.Default.infoArray.Add(Properties.Settings.Default.info3);
            Properties.Settings.Default.infoArray.Add(Properties.Settings.Default.info4);
            Properties.Settings.Default.infoArray.Add("test");
            Properties.Settings.Default.infoArray.Add("dynamic editing");
            Properties.Settings.Default.infoArray.Add("Museum Info Test Page");
            Properties.Settings.Default.Save();
        }
    }
    public static class StringExtensions
    {
        public static string TruncateLongString(this string str, int maxLength)
        {
            return str.Substring(0, Math.Min(str.Length, maxLength));
        }
    }

}
