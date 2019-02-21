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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace lab_11_entity_GUI2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerList = new List<string>();
        Customer customer;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using(NorthwindEntities db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();

                foreach(var c in customers)
                {
                    customerList.Add($"{c.ContactName} has ID of {c.CustomerID}");
                }

                listBox01.ItemsSource = customerList;
            }

            using (NorthwindEntities db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                listBox02.ItemsSource = customers;
            }

            using (NorthwindEntities db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                listBox03.ItemsSource = customers;
                listBox03.DisplayMemberPath = "ContactName";
            }
        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)listBox03.SelectedItem;
            textBoxName.Text = customer.ContactName;
        }
    }
}
