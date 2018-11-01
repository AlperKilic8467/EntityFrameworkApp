//Alper Kilic
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
using Uppgift3BLL;
using Entities.buildinfiles;
using System.Data;

namespace Uppgift3UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller con = new Controller();
        int SelectedID;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            Datagrid.ItemsSource = con.GetAll();

            AddModBtn.IsEnabled = false;

            CategoryCB.ItemsSource = Enum.GetValues(typeof(Category));

            CountryCB.ItemsSource = Enum.GetValues(typeof(Countries));
        }

        private void Update()
        {
            Datagrid.ItemsSource = con.GetAll();
            CityTB.Clear();
            ZipTB.Clear();
            StreetTB.Clear();
           // SpecTB.Clear();
        }

        private void CategoryCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CategoryCB.SelectedIndex == 0)
            {
                TypeCB.ItemsSource = Enum.GetValues(typeof(ResType));

            }
            else if (CategoryCB.SelectedIndex == 1)
            {
                TypeCB.ItemsSource = Enum.GetValues(typeof(ComType));
            }
        }

        private void TypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string cat = CategoryCB.Text;
            string type = TypeCB.Text;
            string country = CountryCB.Text;
            string city = CityTB.Text;
            string street = StreetTB.Text;
            string zip = ZipTB.Text;
            string spec = "Specification";

            Adress Aobj = new Adress(city, street, zip, country);

            try
            {
                if (!string.IsNullOrEmpty(cat) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(zip))
                {

                    if(type == "Appartment")
                    {
                        Appartment obj = new Appartment(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        Update();
                        MessageBox.Show("ADDED!");

                    }
                    if (type == "House")
                    {
                        House obj = new House(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        Update();
                        MessageBox.Show("ADDED!");
                    }
                    if (type == "Villa")
                    {
                        Villa obj = new Villa(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        Update();
                        MessageBox.Show("ADDED!");
                    }
                    if (type == "Townhouse")
                    {
                        Townhouse obj = new Townhouse(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        Update();
                        MessageBox.Show("ADDED!");
                    }
                    if (type == "Shop")
                    {
                        Shop obj = new Shop(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        Update();
                        MessageBox.Show("ADDED!");
                    }
                    if (type == "Warehouse")
                    {
                        Warehouse obj = new Warehouse(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        Update();
                        MessageBox.Show("ADDED!");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the forms!!");
                }
            }

            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SelectedID >= 1)
                {
                    con.Delete(SelectedID);
                    Update();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        private void ModifyBtn_Click(object sender, RoutedEventArgs e)
        {
            CategoryCB.Text = con.GetListing(SelectedID).Cat;
            //TypeCB.Text = con.GetListing(SelectedID).
            CountryCB.Text = con.GetListing(SelectedID).Adress.Country;
            CityTB.Text = con.GetListing(SelectedID).Adress.City;
            StreetTB.Text = con.GetListing(SelectedID).Adress.Street;
            ZipTB.Text = con.GetListing(SelectedID).Adress.Zip;
            AddBtn.IsEnabled = false;
            AddModBtn.IsEnabled = true;
        }

        private void AddModBtn_Click(object sender, RoutedEventArgs e)
        {
            string cat = CategoryCB.Text;
            string type = TypeCB.Text;
            string country = CountryCB.Text;
            string city = CityTB.Text;
            string street = StreetTB.Text;
            string zip = ZipTB.Text;
            string spec = "Specification";

            Adress Aobj = new Adress(city, street, zip, country);
            try
            {

                if (!string.IsNullOrEmpty(cat) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(zip))
                {
                    if (type == "Appartment")
                    {
                        Appartment obj = new Appartment(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        con.Delete(SelectedID);
                        Update();
                        
                        MessageBox.Show("Updated");

                    }
                    if (type == "House")
                    {
                        House obj = new House(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        con.Delete(SelectedID);
                        Update();
                        MessageBox.Show("Updated!");
                    }
                    if (type == "Villa")
                    {
                        Villa obj = new Villa(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        con.Delete(SelectedID);
                        Update();
                        MessageBox.Show("Updated!");
                    }
                    if (type == "Townhouse")
                    {
                        Townhouse obj = new Townhouse(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        con.Delete(SelectedID);
                        Update();
                        MessageBox.Show("Updated!");
                    }
                    if (type == "Shop")
                    {
                        Shop obj = new Shop(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        con.Delete(SelectedID);
                        Update();
                        MessageBox.Show("Updated!");
                    }
                    if (type == "Warehouse")
                    {
                        Warehouse obj = new Warehouse(cat, Aobj, spec, type);
                        con.AddListing(obj);
                        con.Delete(SelectedID);
                        Update();
                        MessageBox.Show("Updated!");
                    }
                    AddBtn.IsEnabled = true;
                    AddModBtn.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("Please fill all the forms!!");
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void Datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Datagrid.SelectedItem == null) return;
            var SelectedBuild = Datagrid.SelectedItem as Building;
            SelectedID = SelectedBuild.BuildingID;
           // SelectedType = SelectedBuild.
        }
    }
}
