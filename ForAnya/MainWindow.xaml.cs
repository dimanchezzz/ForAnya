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

namespace ForAnya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void up(object sender, KeyEventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Name.Split('_')[1]);
            TextBox next = null;
            if (e.Key == Key.Back || e.Key == Key.Delete)
            {
                next = (TextBox)q1.FindName("block_" + (index - 1).ToString());
            }
            else
            {
                
                next = (TextBox)q1.FindName("block_" + (index + 1).ToString());
                
            }
            if (next != null)
            {
                next.Focus();
            }



        }
    }
}
