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
        //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = testFun; Integrated Security = True";
        DBConnection db;

        public NewStaff()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {

            if (tbSurname.Text == "") // поверка на пустоту поля 'фамилия'
            {
                MessageBox.Show("Поле 'Фамилия' не может быть пустым!", "Ввод значения", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                MainWindow main = Owner as MainWindow;
                if (main != null)
                    using (db = new DBConnection())
                {
                       // string Date = Convert.ToDateTime(date.Text).ToString("yyyyMMdd"); //конвертируем чтоб работало с SQL

                        //  DateTime Date = DateTime.Parse(date.Text);
                        //  string cc = Convert.ToString(comboBox1.SelectedValue);


                        // DateTime iDate;

                        Staff l = new Staff();
                    l.Surname = tbSurname.Text;
                    l.Name = tbName.Text;
                    l.Patronymic = tbPatronymic.Text;
                    l.Gender = Gen.Text;
                    

                       
                        


                        Subdivision k = new Subdivision();
                        k.Name = Sub.Text;

                        db.Staffs.Add(l);
                        db.Subdivisions.Add(k);
                        db.SaveChanges();

                    }


                MessageBox.Show("Данные внесены успешно!", "Запись в базу данных", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                main.UpdateData();
            }

            //очистка полей после внесения данных

            tbSurname.Clear();
            tbName.Clear();
            tbPatronymic.Clear();
           // dateTimePicker1.ResetText(); // сброс даты
            Sub.SelectedIndex = -1; // сбрасы индекса выборки 'отдела'
           



        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

           
    }
}
