using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace pz_012
{
    public class Lesson
    {
        public int Id { get; set; } // поле / свойство
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public partial class MainWindow : Window
    {
        Random uuu;
        int tempCount;
        List<Lesson> lesson; // объявляем

        int temp;

        public MainWindow()
        {
            InitializeComponent();

            uuu = new(); // рандом
            lesson = new List<Lesson>(); // конкретно уже инициализировали
            temp = uuu.Next();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer x = new(typeof(List<Lesson>));

            if (tbId.Text == "") // если айдишник пустой!
            {
                using (FileStream fs = new("lesson" + temp.ToString() + ".xml", FileMode.OpenOrCreate)) // файл стрим второй курс практики но тоже ваш код
                {
                    x.Serialize(fs, lesson); // сериализ 

                    MessageBox.Show("ok", "ok", MessageBoxButton.YesNoCancel, MessageBoxImage.Stop); // красоту наводим мэсаг боукса
                }

                return;
            }

            lesson.Add(new Lesson() { Id = int.Parse(tbId.Text), Name = tbName.Text, Description = tbDescription.Text }); // добавляем в так называемый динамический массив (list) новую запись объект
            tempCount++; // ну просто показываем сколько раз уже тыкнули заполнили
            MessageBox.Show(tempCount.ToString() + "/" + "...", "ok"); // отображаем

            #region КОММЕНТАРИИ


            //Lesson a = new() { Id = int.Parse(tbId.Text), Name = tbName.Text, Description=tbDescription.Text };

            //XmlSerializer x = new(typeof(Lesson));
            //using (FileStream fs = new("lesson"+temp.ToString()+".xml", FileMode.OpenOrCreate))
            //{
            //    x.Serialize(fs, a);

            //    MessageBox.Show("ok", "ok", MessageBoxButton.YesNoCancel, MessageBoxImage.Stop);
            //}

            #endregion

        }

        private void btnUn_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer x = new(typeof(List<Lesson>));

            using (FileStream fs = new FileStream(tbSearch.Text + ".xml", FileMode.OpenOrCreate))
            {
                var newpeople = x.Deserialize(fs) as List<Lesson>;

                if (newpeople != null)
                {
                    foreach (Lesson person in newpeople)
                    {
                        lbDesir.Items.Add(person.Name);
                    }
                }
            }

        }

        private void lbDesir_Drop(object sender, DragEventArgs e)
        {
            lbDesir.Items.Clear();

            //MessageBox.Show(e.Data.GetDataPresent(DataFormats.StringFormat));
            string[] fss = (string[])e.Data.GetData(DataFormats.FileDrop);

            XmlSerializer x = new(typeof(List<Lesson>));

            using (FileStream fs = new FileStream(fss[0], FileMode.Open))
            {
                var newpeople = x.Deserialize(fs) as List<Lesson>;

                if (newpeople != null)
                {
                    foreach (Lesson person in newpeople)
                    {
                        lbDesir.Items.Add(person.Name);
                    }

                }

            }

        }

        private void lbDesir_DragOver(object sender, DragEventArgs e)
        {

        }

        private void lbDesir_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void lbDesir_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
    }
}
