using pz_008.Model.Domain;
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

namespace pz_008
{
    /// <summary>
    /// Логика взаимодействия для ContactInfoPage.xaml
    /// </summary>
    public partial class ContactInfoPage : Page
    {
        bool firstView = true;
        public ContactInfoPage()
        {
            InitializeComponent();
            firstView = !firstView;

            foodInfo.DataContext = new FoodContact("dfdsg", 42344312,"fsdsfd","fsddf", new string[] { "fsdf", "fsdfsd"});
        }
    }
}
