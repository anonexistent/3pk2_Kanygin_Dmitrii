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
using System.ComponentModel;

namespace pz_008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IContact currentPhone;

        List<IContact> PhoneBook;

        ContactInfoPage infoPage;
        int ii = 0;

        public MainWindow()
        {
            InitializeComponent();
            infoPage = new();
            PhoneBook = new();

            nWin.Content = infoPage;

            FoodContactFactory testFactory = new FoodContactFactory("sdds", 4324, "fsdf", "sfe", new string[] { "dasd", "fsdfsd", "fsdfsdf" });
            SchoolContactFactory testFactory2 = new("schooooool", 123456789, "orenberg, street2, 10/3", "techno", 1000);
            PersonContactFactory testFactory3 = new("person1", 89198546795, "russia");

            currentPhone = testFactory2.GetContact();
            ////MessageBox.Show(TypeDescriptor.GetClassName(currentPhone).Split('.').Last());
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
            //currentPhone = new PersonContactFactory("zxczxc", 1234, "moscow").GetContact();

            //nWin = new Frame();

            PhoneBook.Add(currentPhone);

            infoPage = new ContactInfoPage() { Title = $"page {ii}" };
            infoPage.foodInfo.DataContext = currentPhone;

            nWin.Content = infoPage;
            
            ((ListBoxItem)whoCallMe).Content = $"contact{ii}";

            ii++;
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uint currentContactNumber = (uint)((ListBox)sender).SelectedIndex-1;

            if (currentContactNumber < PhoneBook.Count)
            {
                infoPage = new ContactInfoPage() { Title = $"page {currentContactNumber}" };

                string currentContactType = TypeDescriptor.GetClassName(PhoneBook[(int)currentContactNumber]).Split('.').Last();
                switch (currentContactType)
                {
                    case "FoodContact":
                        infoPage.pesonInfo.Visibility = Visibility.Hidden;
                        infoPage.schoolInfo.Visibility = Visibility.Hidden;
                        infoPage.foodInfo.Visibility = Visibility.Visible;
                        infoPage.foodInfo.DataContext = PhoneBook[(int)currentContactNumber];
                        break;
                    case "PersonContact":
                        infoPage.schoolInfo.Visibility = Visibility.Hidden;
                        infoPage.foodInfo.Visibility = Visibility.Hidden;
                        infoPage.pesonInfo.Visibility = Visibility.Visible;
                        infoPage.pesonInfo.DataContext = PhoneBook[(int)currentContactNumber];
                        break;
                    case "SchoolContact":
                        infoPage.pesonInfo.Visibility= Visibility.Hidden;
                        infoPage.foodInfo.Visibility= Visibility.Hidden;
                        infoPage.schoolInfo.Visibility = Visibility.Visible;
                        infoPage.schoolInfo.DataContext = PhoneBook[(int)currentContactNumber];
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
