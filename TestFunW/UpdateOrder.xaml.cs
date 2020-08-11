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
using System.Windows.Shapes;

namespace TestFunW
{
    /// <summary>
    /// Логика взаимодействия для UpdateOrder.xaml
    /// </summary>
    public partial class UpdateOrder : Window
    {
        int IdLocal;
        DBConnection db;
        public UpdateOrder(int StaffId)
        {
            InitializeComponent();
            IdLocal = StaffId;
            bindCombo();



            using (db = new DBConnection())
            {


                Order selectOrder = (from s in db.Order
                                     where s.StaffId == IdLocal
                                     select s).Single();


                 Staff selectStaff = (from t in db.Staff
                                      where t.StaffId == IdLocal
                                      select t).Single();

                



                tbNameUPD.Text = selectOrder.Name;
                tbNumberUPD.Text = selectOrder.Number;
                comboSTAFFUPD.Text = selectStaff.Surname;




            }


        }

        public List<Staff> St { get; set; }
        private void bindCombo()
        {
            using (db = new DBConnection())
            {
                var item = db.Staff.ToList();
                St = item;
                DataContext = St;
            }
        }

        private void btSaveUPD_Click(object sender, RoutedEventArgs e)
        {
            if ((tbNameUPD.Text == "") || (tbNumberUPD.Text == "") || (comboSTAFFUPD.Text == ""))
            {
                MessageBox.Show("Не введено значение(я), проверка ввода значений!", "Ввод значения", MessageBoxButton.OK, MessageBoxImage.Error);


            }
            else
            { 
                MainWindow main = Owner as MainWindow;
                if (main != null)
                    using (db = new DBConnection())
                    {

                        



                        Order updateOrder = (from s in db.Order
                                             where s.StaffId == IdLocal
                                             select s).Single();


                        Staff updateStaff = (from k in db.Staff
                                        where k.Surname == comboSTAFFUPD.Text
                                        select k).Single();




                        using (var transaction = db.Database.BeginTransaction())
                        {
                            updateOrder.Number = tbNumberUPD.Text;
                            updateOrder.Name = tbNameUPD.Text;
                            updateOrder.StaffId = updateStaff.StaffId;
                            db.SaveChanges();
                            transaction.Commit();

                        }

                    }

                MessageBox.Show("Данные обновлены успешно!", "Запись в базу данных", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                main.UpdateData();


                //очистка полей после внесения данных

                tbNumberUPD.Clear();
                tbNameUPD.Clear();
                comboSTAFFUPD.SelectedIndex = -1;

                Close();
                main.UpdateData();
            }
            
        }

        private void btCloseUPD_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
