using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock main;
        public TextBlock Main{get { return main; }}

        private TextBlock second;
        public MainWindow()
        {
            InitializeComponent();
            main = this.TB_Main;
            second = this.TB_Second;
        }

        private void Btn_Zero_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('0');
        }

        private void Btn_One_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('1');
        }

        private void Btn_Two_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('2');
        }

        private void Btn_Three_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('3');
        }

        private void Btn_Four_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('4');
        }

        private void Btn_Five_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('5');
        }

        private void Btn_Six_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('6');
        }

        private void Btn_Seven_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('7');
        }

        private void Btn_Eight_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('8');
        }

        private void Btn_Nine_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('9');
        }


        private void Btn_Divide_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('/');
        }

        private void Btn_Multi_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('*');
        }

        private void Btn_Minus_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('-');
        }

        private void Btn_Plus_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain('+');
        }

        private char separator = '.';
        public char Separator { get { return separator; } }
        private void Btn_Dote_Click(object sender, RoutedEventArgs e)
        {
            AddSympbolInTBMain(separator);
        }

        private void Btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearAllInTB();
        }

        private void Btn_Backspace_Click(object sender, RoutedEventArgs e)
        {
            Backspace();
        }

        public void AddSympbolInTBMain(char ch)
        {
            main.Text += ch;
        }   

        private void ClearAllInTB()
        {
            main.Text = String.Empty;
            second.Text = String.Empty;
        }

        private void Backspace()
        {
            if(main.Text.Length > 0){
                main.Text = main.Text.Remove(main.Text.Length - 1);
            }
        }



    }
}
