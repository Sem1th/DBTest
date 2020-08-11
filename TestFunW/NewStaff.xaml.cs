using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для NewStaff.xaml
    /// </summary>
    public partial class NewStaff : Window
    {
        
        DBConnection db;

        public NewStaff()
        {
            InitializeComponent();
            Gen.ItemsSource = Enum.GetValues(typeof(Gender));
            Gen.SelectedIndex = 0;
            

        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {

            if (tbSurname.Text == "") // поверка на пустоту поля 'фамилия'
            {
                MessageBox.Show("Поле 'Фамилия' не может быть пустым!", "Ввод значения", MessageBoxButton.OK, MessageBoxImage.Error);
                Gen.SelectedIndex = 0;

            }
            else
            {
                
                MainWindow main = Owner as MainWindow;
                if (main != null)
                    using (db = new DBConnection())
                    {



                        Staff first = new Staff();
                        first.Surname = tbSurname.Text;
                        first.Name = tbName.Text;
                        first.Patronymic = tbPatronymic.Text;
                        first.Date = date.SelectedDate.Value.Date;
                        first.GenderValues = (Gender)Gen.SelectedValue;



                        Subdivision second = new Subdivision();
                        second.NameSubdivision = Sub.Text;

                       

                        using (var transaction = db.Database.BeginTransaction())
                        {

                            db.Staff.Add(first);
                            db.SaveChanges();
                            second.StaffId = first.StaffId;
                            db.Subdivision.Add(second);
                            first.SubdivisionId = second.SubdivisionId;
                            db.SaveChanges();
                            transaction.Commit();

                        }
                    }


                MessageBox.Show("Данные внесены успешно!", "Запись в базу данных", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                main.UpdateData();
            }

            //очистка полей после внесения данных

            tbSurname.Clear();
            tbName.Clear();
            tbPatronymic.Clear();
            
            date.SelectedDate = DateTime.Now; // сброс даты
            Gen.SelectedIndex = 0;
            Sub.SelectedIndex = -1; // сбрасы индекса выборки 'отдела'
           



        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

           
    }
}
