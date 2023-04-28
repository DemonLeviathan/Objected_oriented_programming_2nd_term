using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace lr_4_5
{
    /// <summary>
    /// Логика взаимодействия для UserAccountPage.xaml
    /// </summary>
    public partial class UserAccountPage : Window
    {
        private string phoneNumber;

        public UserAccountPage()
        {
            InitializeComponent();

        }
        public UserAccountPage(string phoneNumber)
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
            userPhoneNumber.Text = "+" + phoneNumber;
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < 100)
            {

            }
        }
    }
}
