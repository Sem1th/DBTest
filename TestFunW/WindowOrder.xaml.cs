using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
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
        

       // int IdLocal;
        public WindowOrder()
        {
            InitializeComponent();
            bindCombo();
            // comboSTAFF.ItemsSource = typeof(Staff).GetProperties();

            

        }
        //связывем combobox с таблицей Staff для выбора сотрудника
       public List<Staff> St { get; set; }
       private void bindCombo()
        {
            using (db = new DBConnection())
            {
                var item = db.Staff.ToList() ;
                St = item;
                DataContext = St;
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if ((tbName.Text == "") || (tbNumber.Text == "") || (comboSTAFF.Text == ""))
            {
                MessageBox.Show("Не введено значение(я), проверка ввода значений!", "Ввод значения", MessageBoxButton.OK, MessageBoxImage.Error);
                

            }
            else
            {
                MainWindow main = Owner as MainWindow;
                if (main != null)
                    using (db = new DBConnection())
                    {





                        Order order = new Order();

                        order.Number = tbNumber.Text;
                        order.Name = tbName.Text;

                        //Staff second = new Staff();
                        // second.Surname = comboSTAFF.Text;

                        Staff select = (from k in db.Staff
                                        where k.Surname == comboSTAFF.Text
                                        select k).Single();


                        using (var transaction = db.Database.BeginTransaction())
                        {

                            db.Order.Add(order);
                            db.SaveChanges();

                            order.StaffId = select.StaffId;
                            db.SaveChanges();


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
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        }
    }

