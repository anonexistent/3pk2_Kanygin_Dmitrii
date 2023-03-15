using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

/* Реализовать графическое приложение, содержащее:
• Метод, производящий длительные вычисления в цикле, с задержкой между каждой 
итерацией в 0,5 секунды. Данный метод запускается при нажатии на кнопку.
• Поле InkCanvas в котором пользователь имеет возможность рисовать.
• ProgressBar, в котором отображается прогресс выполнения метода.
• Проанализировать работу приложения в синхронном режиме.
• Произвести необходимые изменения для работы в асинхронном режиме. Сделайте 
выводы 
• Выводы оформить в виде многострочного комментария в проекте. */

namespace assucscy_1_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        async Task ReloadProgress(double value) => pb1.Value = value;

        //  тут паралельно асинхроный
        async Task Work(decimal a, int i)
        {
            for (int n = 0; n < i; n++)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.5f));

                a += (decimal)Math.Sqrt((double)a);
                a = (decimal)Math.Pow((double)a, -1);
                a = (decimal)Math.Sqrt((double)a);
                a /= (decimal)((double)a * Math.Sqrt((double)a));

                //ReloadProgress(99 / n);
                pb1.Value = 100 - 101 / (n + 1);

                Trace.WriteLine(n);

                tb1.Text = $"{a:f25}";
            }

            MessageBox.Show("work end the", "work.");
        }

        //  здесь не асинхронный
        void Work2(decimal a, int i)
        {
            for (int n = 0; n < i; n++)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.5f));

                a += (decimal)Math.Sqrt((double)a);
                a = (decimal)Math.Pow((double)a, -1);
                a = (decimal)Math.Sqrt((double)a);
                a /= (decimal)((double)a * Math.Sqrt((double)a));

                //ReloadProgress(99 / n);
                pb1.Value = 100 - 101 / (n + 1);

                Trace.WriteLine(n);

                tb1.Text = $"{a:f25}";
            }

            MessageBox.Show("work end the", "work.");
        }

        //  происходит на форме установка или не утсановка голочки какой метод запустить и происходит действие работы
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)cb1.IsChecked) Work(3, int.MaxValue / int.Parse(tb3.Text));
            else Work2(3, int.MaxValue / int.Parse(tb3.Text));
        }
    }
}
