using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PRNINE;
using static PRNINE.Class1;

namespace PrNine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Participant[] participant; //массив участников забега
        private int participantCount;
        public MainWindow()
        {
            InitializeComponent();
            participant = new Participant[8]; //можно заполнить в масив максимум 8 участников
            participantCount = 0; //счетчик участников забега начинается с нуля
        }
        //Кнопка о программе
        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Сухомяткина Ксения ИСП-34\nНомер работы: 9\nЗадание: Заполнить таблицу участников забега на 100 метров на 8 человек с полями: ФИО, номер, результат. Вывести результат на экран. Вывести средний результат.", "❗ О программе");
        }
        //Кнопка выхода
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Кнопка добавления участников
        private void AddPeople(object sender, RoutedEventArgs e)
        {
            if (participantCount < 8)
            {
                string fio = fio_TB.Text;
                if (int.TryParse(num_TB.Text, out int number) && double.TryParse(res_TB.Text,out double result))
                {
                    participant[participantCount] = new Participant(fio,number,result);
                    participantCount++;
                    //очистка полей ввода
                    fio_TB.Clear();
                    num_TB.Clear();
                    res_TB.Clear();

                 
                }
                else
                {
                    MessageBox("Пожалуста, введите")
                }

            }
        }
    }
}