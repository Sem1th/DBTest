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
                var item = db.Staff.ToList() ;
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


                    

                    Order order = new Order();
                   
                    order.Number = tbNumber.Text;
                    order.Name = tbName.Text;
                    // l.Employer = comboSTAFF.Text;
                    // order.StaffId = int.Parse(comboSTAFF.Text);

                   // Staff second = new Staff();
                   // second.Surname = comboSTAFF.Text;




                    using (var transaction = db.Database.BeginTransaction())
                    {

                        db.Order.Add(order);
                        db.SaveChanges();

                       // second.StaffId = (int)order.StaffId;
                    

                       // db.SaveChanges();
                        transaction.Commit();

                    }

                }


            MessageBox.Show("Данные внесены успешно!", "Запись в базу данных", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            main.UpdateData();
        

             //очистка полей после внесения данных

             tbNumber.Clear();
             tbName.Clear();
            comboSTAFF.SelectedIndex = -1;

        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        }
    }

