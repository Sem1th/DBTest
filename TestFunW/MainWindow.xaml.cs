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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestFunW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBConnection db;


        public MainWindow()
        {
            InitializeComponent();

            UpdateData();
           // DataContext = new ApplicationViewModel();

        }

        public void UpdateData()
        {
            db = new DBConnection();
            db.Staff.Load(); // загружаем данные
            db.Subdivision.Load();
            db.Order.Load();
            staffGrid.ItemsSource = db.Staff.Local.ToList(); // устанавливаем привязку к кэшу
            subdivisionGrid.ItemsSource = db.Subdivision.Local.ToBindingList();
            ordersGrid.ItemsSource = db.Order.Local.ToBindingList();
        }

        

        private void newOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowOrder window = new WindowOrder();
            window.Owner = this;
            window.ShowDialog();
        }


        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
             int IdLocal = (staffGrid.SelectedItem as Staff).StaffId;
             UpdateStaff u = new UpdateStaff(IdLocal);
             u.Owner = this;
             u.ShowDialog();
            
           



        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить данные об этом пользователе?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                int IdLocal = (staffGrid.SelectedItem as Staff).StaffId;
                var deleteMember = db.Staff.Where(s => s.StaffId == IdLocal).Single();
                db.Staff.Remove(deleteMember);
                db.SaveChanges();

                using (db = new DBConnection())
                {
                    Subdivision deleteSubdivision = (from k in db.Subdivision
                                                     where k.SubdivisionId == IdLocal
                                                     select k).Single();

                    using (var transaction = db.Database.BeginTransaction())
                    {

                        db.Subdivision.Remove(deleteSubdivision);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                }
                UpdateData();

            }
        }


        private void btCreate_Click(object sender, RoutedEventArgs e)
        {
            NewStaff window = new NewStaff();
            window.Owner = this;
            window.ShowDialog();
        }

        private void btUpdateOrder_Click(object sender, RoutedEventArgs e)
        {

            int IdLocal = (int)(ordersGrid.SelectedItem as Order).StaffId;
            UpdateOrder f = new UpdateOrder(IdLocal);
            f.Owner = this;
            f.ShowDialog();

        }

        private void btDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить данные об этом заказе?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                using (db = new DBConnection())
                {
                int IdLocal = (ordersGrid.SelectedItem as Order).OrderId;
                var deleteMember = db.Order.Where(s => s.OrderId == IdLocal).Single();

                    using (var transaction = db.Database.BeginTransaction())
                    {
                        db.Order.Remove(deleteMember);
                        db.SaveChanges();
                        transaction.Commit();
                    }

                }

                UpdateData();

            }
        }

        private void btMainClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btAddMainNew_Click(object sender, RoutedEventArgs e)
        {
            NewStaff window = new NewStaff();
            window.Owner = this;
            window.ShowDialog();
        }
    }
}
