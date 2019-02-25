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
using System.Diagnostics;

namespace lab_114_update_entity_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>(); //creating a list with the customer object
        Customer customer; //creating an object

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                List<string> cities = new List<string>();
                custListBox.ItemsSource = customers;
                custListBox.DisplayMemberPath = "ContactName";
                                
                foreach (var city in customers)
                {
                    if (!cities.Contains(city.City))
                    {
                        cityDropDown.Items.Add(city.City);
                    }
                }                              
            }
        }

        private void CustListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // allocated selected customer from list box and put it into the object.
            customer = (Customer)custListBox.SelectedItem;

            // put the customer name saved in the object into the text box.
            customerName.Text = customer.ContactName;

            // put the customer city saved in the object into the lable for city
            cityLabel.Content = customer.City;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                // get object of customer to update where the name selected matched the name in the database and retunt the first one
                var nameToUpdate = db.Customers.Where(c => c.ContactName == customer.ContactName).FirstOrDefault();

                // get object of customer to update where the city selected matched the city in the database and retunt the first one
                var cityToUpdate = db.Customers.Where(c => c.City == customer.City).FirstOrDefault();

                nameToUpdate.ContactName = Convert.ToString(customerName.Text);
                cityToUpdate.City = (cityDropDown.SelectedItem as string);

                db.SaveChanges();
            }
        }
    }
}
