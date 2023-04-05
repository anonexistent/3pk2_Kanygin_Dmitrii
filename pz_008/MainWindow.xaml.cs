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
using pz_008.Model.Factory;
using pz_008.Model.Domain;

namespace pz_008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IContact currentPhone;

        ContactInfoPage infoPage;
        int ii = 0;

        public MainWindow()
        {
            InitializeComponent();

            infoPage = new();

            nWin.Content = infoPage;

            FoodContactFactory testFactory = new FoodContactFactory("sdds", 4324, "fsdf", "sfe", new string[] { "dasd", "fsdfsd", "fsdfsdf" });
            SchoolContactFactory testFactory2 = new("schooooool", 123456789, "orenberg, street2, 10/3", "techno", 1000);
            PersonContactFactory testFactory3 = new("person1", 89198546795, "russia");

            currentPhone = testFactory2.GetContact();
            //currentPhone = testFactory.GetContact();
            //currentPhone = testFactory3.GetContact();
            //MessageBox.Show(string.Join('\n', currentPhone.GetInfo()));
        }

        private void ListBoxItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var a = new ListBoxItem() { };

            listBox1.Items.Add(a);

            DrawNewContact(a);
        }

        private void DrawNewContact(object whoCallMe)
        {
            //nWin = new Frame();

            ContactInfoPage c = new ContactInfoPage() { Title = $"page {++ii}" };
            c.foodInfo.DataContext = currentPhone;

            nWin.Content = c;
            
            ((ListBoxItem)whoCallMe).Content = $"contact{ii}";
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
