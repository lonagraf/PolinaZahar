using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace f
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        bool islocked = false;
        static Random random = new Random();
        List<TextBlock> matrx;
        public MainWindow()
        {
            InitializeComponent();
            matrx = new List<TextBlock>();
            FillMatrix();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!islocked)
            {
                for (int i = 0; i < matrx.Count; i++)
                {
                    matrx[i].Text = i.ToString();
                }
            }


        }

        private void FillMatrix()
        {

            if (!islocked)
            {
             
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        

                        TextBlock temp = (TextBlock)GetChildren(MatrixGrid, i, j);
                       
                        matrx.Add(temp);
                    }
                }
            }

        }

        private static UIElement GetChildren(Grid grid, int row, int column)
        {
            foreach (UIElement child in grid.Children)
            {
                if (Grid.GetRow(child) == row
                      &&
                   Grid.GetColumn(child) == column)
                {
                    return child;
                }
            }
            return null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (!islocked)
            {
                zero_zero.Text = null;
                one_zero.Text = null;
                two_zero.Text = null;
                three_zero.Text = null;
                zero_one.Text = null;
                one_one.Text = null;
                two_one.Text = null;
                three_one.Text = null;
                zero_two.Text = null;
                one_two.Text = null;
                two_two.Text = null;
                zero_three.Text = null;
                three_three.Text = null;
                one_three.Text = null;
                two_three.Text = null;
                three_three.Text = null;
                three_two.Text = null;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            islocked = true;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            islocked = false;
        }

        private void Columns_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            
          
        }

        private void Rows_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}


