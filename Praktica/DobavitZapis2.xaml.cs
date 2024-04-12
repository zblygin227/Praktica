using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для DobavitZapis2.xaml
    /// </summary>
    public partial class DobavitZapis2 : Window
    {
        agentstvo5Entities db = agentstvo5Entities.GetContext();
        Agent p2 = new Agent();
        public DobavitZapis2()
        {
            InitializeComponent();
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (ID.Text.Length == 0) errors.AppendLine("Введите ID");
            if (FIO.Text.Length == 0) errors.AppendLine("Введите ФИО");
            if (Doly.Text.Length == 0) errors.AppendLine("Введите долю от комиссии");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p2.Id = Convert.ToInt32(ID.Text);
            p2.FirstName = FIO.Text;
            p2.MiddleName = FIO.Text;
            p2.LastName = FIO.Text;
            p2.DealShare = Convert.ToInt32(Doly.Text);

            try
            {
                db.Agents.Add(p2);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}


    
    

