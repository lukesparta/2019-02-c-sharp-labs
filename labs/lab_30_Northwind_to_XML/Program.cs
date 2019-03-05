using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace lab_30_Northwind_to_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            //read northwind
            using (var db = new Northwind())
            {
                products = db.Products.OrderBy(p => p.ProductName).Take(3).ToList();
            }

            products.ForEach(p => Console.WriteLine(p.ProductName));


            //extract products
            Console.WriteLine("\n\nExtracting to XML\n");

            var xml = new XElement("products",
                from p in products
                select new XElement("Products",
                new XAttribute("ProductID", p.ProductID),
                new XAttribute("Price", p.Cost),
                new XAttribute("ProductName", p.ProductName)
                ));
            Console.WriteLine(xml.ToString());
            //writwe to xml
            var doc = new XDocument(xml);
            doc.Save("Products.xml");

            // no the test
            Console.WriteLine("\n\nFirstly read back raw XML data as a string.\n");
            Console.WriteLine(File.ReadAllText("Products.xml"));

            // as XML Document
            var doc2 = XDocument.Load("Products.xml");
        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            this.Products = new List<Product>();
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "../../../../data/Northwind.db");
            // use SQLite
            optionsBuilder.UseSqlite($"Filename={path}");
            // use SQL
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=Northwind;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            // filter out discontinued products
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.Discontinued);
        }
    }

    //This class will hold the deserialised objects (casting XML back into list of products)
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Products> productList { get; set; }
    }
}
