using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
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

namespace TestFunW
{
    /// <summary>
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>
    public partial class WindowOrder : Window
    {

        DBConnection db;
        public WindowOrder()
        {
            InitializeComponent();
            bindCombo();
        }

        public List<Staff> Emp { get; set; }
        private void bindCombo()
        {
            using (db = new DBConnection())
            {
                var item = db.Staffs.ToList();
                Emp = item;
                DataContext = Emp;
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Owner as MainWindow;
            if (main != null)
                using (db = new DBConnection())
                {


                    

                    Order l = new Order();
                   
                    l.Number = tbNumber.Text;
                    l.Name = tbName.Text;
                    l.Employer = comboSTAFF.Text;

                    db.Orders.Add(l);
                    db.SaveChanges();

                }


            MessageBox.Show("Данные внесены успешно!", "Запись в базу данных", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            main.UpdateData();
        

             //очистка полей после внесения данных

             tbNumber.Clear();
            tbName.Clear();
         
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}
