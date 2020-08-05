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

            //db = new DBConnection();
            //db.Staffs.Load(); // загружаем данные
            //staffGrid.ItemsSource = db.Staffs.Local.ToBindingList(); // устанавливаем привязку к кэшу

            // this.Closing += MainWindow_Closing;

        }

        public void UpdateData()
        {
            db = new DBConnection();
            db.Staff.Load(); // загружаем данные
            db.Subdivision.Load();
            db.Order.Load();
            staffGrid.ItemsSource = db.Staff.Local.ToBindingList(); // устанавливаем привязку к кэшу
           // staffGrid.ItemsSource = db.Subdivision.Local.ToBindingList();
            subdivisionGrid.ItemsSource = db.Subdivision.Local.ToBindingList();
            ordersGrid.ItemsSource = db.Order.Local.ToBindingList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           



            // Create a window
           NewStaff window = new NewStaff();

            window.Owner = this;

            // Open a window
            window.ShowDialog();


           
        }

        private void newOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowOrder window = new WindowOrder();

            window.Owner = this;

            // Open a window
            window.ShowDialog();
        }


        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateStaff u = new UpdateStaff();
            u.Owner = this;
            u.ShowDialog();

        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
