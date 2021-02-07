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
using System.Windows.Shapes;

namespace ForAnya
{
    /// <summary>
    /// Логика взаимодействия для happy.xaml
    /// </summary>
    public partial class happy : Window
    {
        public happy(Window a)
        {
            InitializeComponent();
            a.Close();
            textLabel.Content = @"Если ты читаешь, значит ты прошла кроссворд)))
            Надеюсь, у тебя настроение огого))) Хочу пожелать тебе здоровья вагон и маленькую тележку))
            Чтобы ты радовалась жизни, ценила как можно больше моментов)
            Мы с тобой мало знакомы, но по тому времени, что мы общаемся, ты для меня стала замечательным человеком.
            Я безумно рад тому, что знаю такого человечка как ты.
            Что жизнь вот так повеливает и сводит двух далеко далеко живущих людей)
            Я верю в то, что мы с тобой когда-то встретимся.
            В голове, конечно, все красиво))
            Поздравляю тебя с днем рождения) Это классный день, когда можно абсолютно все)
            Мне очень жаль, что я не смогу тебя поздравить лично
            Ты классная, ты всегда можешь мне написать, позвонить, я бесконечно рад, когда тебя слушаю.
            У тебя просто сумасшедший смех))))) Ты смеешься как ребенок, и это превосходно)
                Спасибо тебе за то что есть такая девочка как ты. ПОЗДРАВЛЛЯЮ!!!!
                    Жми <<Далее>>            
";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/qHtrjuw0hqY?t=62");
        }
    }
}
