using Microsoft.Win32;
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
using System.Xml.Linq;

namespace pz_010
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ComboBoxItem> fontSizes;

        public MainWindow()
        {
            InitializeComponent();

            fontSizes = new List<ComboBoxItem>();
            makeFontSizes();

        }

        void makeFontSizes()
        {
            for (int i = 0; i < 10; i++)
            {
                fontSizes.Add(new ComboBoxItem { Content = $"{14 + i*2}" });
                newFontSize.Items.Add(fontSizes[i]);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_Bold(object sender, RoutedEventArgs e)
        {
            //textBox.Selection.ApplyPropertyValue(FontSizeProperty, FontSize-FontSize+18);
            textBox.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
        }
        private void MenuItem_Click_Italic(object sender, RoutedEventArgs e)
        {
            textBox.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }

        private async void newFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Task.Delay(250);
            //MessageBox.Show(((ComboBox)sender).SelectionBoxItem.ToString());
            textBox.Selection.ApplyPropertyValue(FontSizeProperty, ((ComboBox)sender).SelectionBoxItem);
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new();
            dialog.FileName = "index";
            dialog.DefaultExt = ".html";
            dialog.Filter = "Rich Text Files(*.rtf)|*.rtf|html Files(*.html)|*.html|All(*.*)|*";
            dialog.ShowDialog();

            var writeHere = dialog.OpenFile();

            TextRange text = new(textBox.Document.ContentStart, textBox.Document.ContentEnd);
            text.Save(writeHere, DataFormats.Rtf);

            writeHere.Close();
            //using (StreamWriter sw = new(dialog.OpenFile()))
            //{
            //    text.Save(sw, "");
            //}
        }
    }
}
