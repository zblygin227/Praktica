using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Agent.xaml
    /// </summary>

    public partial class Agent : Window
    {
        agentstvo5Entities db = agentstvo5Entities.GetContext();
        public Agent()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.Agents.Load();
            DataGrid1.ItemsSource = db.Agents.Local.ToBindingList();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DobavitZapis2 f = new DobavitZapis2();
            f.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                MessageBoxResult result;
                result = MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        Agent row = (Agent)DataGrid1.SelectedItems[0];
                        db.Agents.Remove(row);
                        db.SaveChanges();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Выберите запись");
                    }

                }
            }
        }
    }
}

//        private void izmenit(object sender, RoutedEventArgs e)
//        {
//            int indexRow = DataGrid2.SelectedIndex;
//            if (indexRow != -1)
//            {
//                Client row = (Client)DataGrid2.SelectedItems[indexRow];
//                Class2.Id = row.Id;
//                IzmenitZapis f = new IzmenitZapis();
//                f.ShowDialog();
//                DataGrid2.Items.Refresh();
//                DataGrid2.Focus();
//            }
//        }

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            for (int i = 0; i < DataGrid2.Items.Count; i++)
//            {
//                var row = (Client)DataGrid2.Items[i];
//                string findContent = row.MiddleName;
//                try
//                {
//                    //if (findContent != null && findContent.Contains(txtFind.Text))
//                    {
//                        object item = DataGrid2.Items[i];
//                        DataGrid2.SelectedItem = item;
//                        DataGrid2.ScrollIntoView(item);
//                        DataGrid2.Focus();
//                        break;
//                    }
//                }
//                catch { }
//            }
//        }
//    }
//}