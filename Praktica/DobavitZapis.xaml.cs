using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Praktica
{
    /// <summary>
    /// Логика взаимодействия для DobavitZapis.xaml
    /// </summary>
    public partial class DobavitZapis : Window
    {
        agentstvo5Entities db = agentstvo5Entities.GetContext();
        Client p1 = new Client();
        public DobavitZapis()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (ID.Text.Length == 0) errors.AppendLine("Введите ID");
            if (FIO.Text.Length == 0) errors.AppendLine("Введите ФИО");
            if (Phone.Text.Length == 0) errors.AppendLine("Введите телефон");
            if (Email.Text.Length == 0) errors.AppendLine("Введите эмэйл");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }       
            p1.Id = Convert.ToInt32(ID.Text);
            p1.FirstName = FIO.Text;
            p1.MiddleName = FIO.Text;
            p1.LastName = FIO.Text;
            p1.Email = Email.Text;
            p1.Phone = Phone.Text;

            try
            {
                db.Clients.Add(p1);
                db.SaveChanges();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }
    }
}
