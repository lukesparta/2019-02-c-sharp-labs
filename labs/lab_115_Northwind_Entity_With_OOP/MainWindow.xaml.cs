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

namespace lab_115_Northwind_Entity_With_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    ///                                     Lab 115
    /// 
    /// Read Customers and  (cast) to ActiveCustomers and
    /// set IsActive to true for all customers.
    /// 
    /// Create 2 list boxes and radio button to enable/disable out ActiveCustomer.
    /// 
    /// Click on Customer to select and display all details on screen (TextBlock, StackPanel, ListBox).
    /// 
    /// When you click on the enable/disable (toggle) button IsActive  (toggles) changes state.
    /// 
    /// First ListBox is only for active customers
    ///     If state becomes inactive ==> remove from first ListBox
    ///     
    /// Second Listbox is only for inactive customers
    ///     inactive state : remove from first but ass to second list box
    ///     
    /// Reverse the process i.e. when you click on an inactive customer (in second ListBox)
    ///     you can then toggle the state back to enabled (using toggle button).
    ///     removed from InActive and add back to Active List.
    ///     
    ///     
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>(); //creating a list with the customer object
        Customer customer; //creating an object
        public MainWindow()
        {
            InitializeComponent();
            Initalize();
        }

        void Initalize()
        {
            Customer c = new Customer();
            //c.DoThis();

            using (NorthwindEntities db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                List<string> cities = new List<string>();
                activeCustomer.ItemsSource = customers;
                activeCustomer.DisplayMemberPath = "ContactName";

                foreach (var customer in customers)
                {
                   
                }
            }
        }

        //Interface is like a tool you can use/implament
        interface IDoThis
        {
            void DoThis();
        }

        interface IDoThat
        {
            void DoThat();
        }

        class ActiveCustomer : Customer, IDoThis, IDoThat
        {
            public bool IsActive;

            public void DoThis()
            {

            }

            public void DoThat()
            {

            }
        }
    }

    
    // class ActiveCustomer **Inheriting** the class Customer
    

    // class customer
    public partial class Customer
    {
        // Can be extended here - add other fields

        //public void DoThis()
        //{
        //    Trace.WriteLine("Customer is doing something");
        //}

    }
}
