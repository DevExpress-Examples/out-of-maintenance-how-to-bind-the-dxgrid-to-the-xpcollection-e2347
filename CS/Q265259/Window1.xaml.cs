using System;
using System.Windows;
using Northwind;
using DevExpress.Xpo;
using System.ComponentModel;

namespace Q265259 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 :Window {
        public Window1() {
            InitializeComponent();
            LoadData();
        }

        Session session;
        XPCollection<Product> products;
        private void LoadData() {
            session = new Session();
            products = new XPCollection<Product>(session);
            products.DisplayableProperties = "ProductName;QuantityPerUnit;UnitPrice;UnitsInStock";
            productsGrid.DataSource = products;
            productsGrid.PopulateColumns();
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            if (products != null) {
                products.Dispose();
                products = null;
            }
            if (session != null) {
                session.Dispose();
                session = null;
            }
        }
    }
}
