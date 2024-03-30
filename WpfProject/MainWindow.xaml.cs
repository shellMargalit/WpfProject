using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1;
        int num2;
        int result;
        int ok;
        int fail;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Visibility = Visibility.Collapsed;
            Random random = new Random();
            num1 = random.Next(1,10);
            num2 = random.Next(1,10);
            int randomNumberToFunction = random.Next(1,4);
            value2.Text = Convert.ToString(num2);
            value1.Text = Convert.ToString(num1); 
            switch (randomNumberToFunction)
            {
                case 1:
                    result=num1 + num2;
                    FunctionTextBox.Text = "+";
                    break;
                case 2:
                    result=num1 - num2;
                    FunctionTextBox.Text = "-";
                    break;
                case 3:
                    result=num1 * num2;
                    FunctionTextBox.Text = "*";
                    break;
                case 4:
                    result=num1 / num2;
                    FunctionTextBox.Text = "/";
                    break;
            }
            Result.Text = Convert.ToString(result); 

        }

        private void AnswerClick(object sender, RoutedEventArgs e)
        {
            double result = double.Parse(Result.Text);
            double answer = double.Parse(AnswerTxt.Text);
            if (result == answer)
                ok++;
            else
                fail++;
            Result.Visibility
                = Visibility.Visible;

        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {
            double grade = ok / (double)(ok + fail);
            int gradePer = (int)Math.Round(grade*100);
            MessageBoxResult result = MessageBox.Show(Convert.ToString(gradePer));
        }

        private void sound_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("C:\\Users\\User\\Downloads\\sound.mp3");
            sound.Load();
            sound.Play();

        }
    }
}
