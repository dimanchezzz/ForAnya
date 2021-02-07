using System;
using System.Collections;
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
            
            DateTime dr = new DateTime(2021, 2, 8, 0, 0, 0);
            DateTime nowTime = DateTime.Now;
            TimeSpan span = dr.Subtract(nowTime);

            if(span.TotalMilliseconds > 0)
            {
                MessageBox.Show("до праздника еще" + "\n" +
                "(seconds): " + span.Seconds + "\n" +
                "(minutes): " + span.Minutes + "\n" +
                "(hours): " + span.Hours + "\n" +
                "ЖДИИИ))");
                this.Close();
            } else if(span.TotalDays < 0)
            {
                MessageBox.Show("День Рождение уже прошло(");
            }
            else
            {
                InitializeComponent();
            }
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool result = checkAnswers();
            if (result)
            {
                checck.Visibility = Visibility.Hidden;
                next.Visibility = Visibility.Visible;
            }
            else
            {
                next.Visibility = Visibility.Hidden;
            }
        }

        private Boolean checkAnswers()
        {

            Dictionary<string, ArrayList> answers = new Dictionary<string, ArrayList> {
                {"копенгаген", new ArrayList{1,2,3,4,5,6,7,8,9,10} },
                {"воронеж", new ArrayList{12,13,14,15,16,17,18} },
                {"рязань", new ArrayList{19,20,21,22,23,24} },
                {"мадрид", new ArrayList{25,26,27,28,29,30} },
                {"рим", new ArrayList{31,32,33} },
                {"таллин", new ArrayList{34,35,36,37,38,39} },
                {"варшава", new ArrayList{40,41,42,43,44,45,46} },
                {"тбилиси", new ArrayList{47,48,49,50,51,52,53} },
                {"софия", new ArrayList{54,55,56,57,58} },
                {"ньюйорк", new ArrayList{59,60,61,62,63,64,65} }

            };

            int count = 0;
            foreach (KeyValuePair<string, ArrayList> entry in answers)
            {
                // do something with entry.Value or entry.Key
                string word = "";
                count = count + 1;
                foreach(int index in entry.Value)
                {
                    TextBox currentBox = (TextBox)q1.FindName("block_" + (index).ToString());
                    word += currentBox.Text;
                }
                if(word.ToLower() != entry.Key.ToLower())
                {
                    MessageBox.Show("ошибка в " + count + " cлове");
                    return false;
                    
                }
                
            }
            return true;
            
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            happy h = new happy(this);
            h.Show();
        }

        
    }
}
