using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
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

namespace Praktica
{
    /// <summary>
    /// Логика взаимодействия для IzmenitZapis.xaml
    /// </summary>
    public partial class IzmenitZapis : Window
    {
        agentstvo5Entities db = new agentstvo5Entities();
        Client p1;
        public IzmenitZapis()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //p1 = db.Clients.Find(Class2.Id);
            //FIO.Text = p1.FirstName;
            //FIO.Text = p1.MiddleName;
            //FIO.Text = p1.LastName;
            //Phone.Text = p1.Phone;
            //Email.Text = p1.Email;

        }
    }
}
