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
    /// Логика взаимодействия для UpdateStaff.xaml
    /// </summary>
    public partial class UpdateStaff : Window
    {
        DBConnection db;

        int IdLocal;
        public UpdateStaff(int StaffId)
        {
            InitializeComponent();
            IdLocal = StaffId;
            Gen1.ItemsSource = Enum.GetValues(typeof(Gender));
          //  Gen1.SelectedIndex = 0;

            
            using (db = new DBConnection())
            {
                Staff selectStaff = (from s in db.Staff
                                     where s.StaffId == IdLocal
                                     select s).Single();

                Subdivision selectSubdivision = (from t in db.Subdivision
                                                 where t.SubdivisionId == IdLocal
                                                 select t).Single();
                tbSurname1.Text = selectStaff.Surname;
                tbName1.Text = selectStaff.Name;
                tbPatronymic1.Text = selectStaff.Patronymic;
                Gen1.SelectedValue = selectStaff.GenderValues;
                Sub1.Text = selectSubdivision.NameSubdivision;
                date1.SelectedDate = selectStaff.Date;
               

            }

                
            }

        private void btUPD_Click(object sender, RoutedEventArgs e)
        {
            if (tbSurname1.Text == "") // поверка на пустоту поля 'фамилия'
            {
                MessageBox.Show("Поле 'Фамилия' не может быть пустым!", "Ввод значения", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                MainWindow main = Owner as MainWindow;
                if (main != null)
                    using (db = new DBConnection())
            {
                Staff updateStaff = (from s in db.Staff
                                     where s.StaffId == IdLocal
                                     select s).Single();

                        Subdivision updateSubdivision = (from k in db.Subdivision
                                                         where k.SubdivisionId == IdLocal
                                                         select k).Single();

                        updateSubdivision.NameSubdivision = Sub1.Text;


                        updateStaff.Surname = tbSurname1.Text;
                        updateStaff.Name = tbName1.Text;
                        updateStaff.Patronymic = tbPatronymic1.Text;
                        updateStaff.Date = date1.SelectedDate.Value.Date;
                        updateStaff.GenderValues = (Gender)Gen1.SelectedValue;


                        using (var transaction = db.Database.BeginTransaction())
                        {

                            db.SaveChanges();
                            transaction.Commit();
                        }

                        Close();
                        main.UpdateData();

                    }
                    }
            }

        private void btCLOSE_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

