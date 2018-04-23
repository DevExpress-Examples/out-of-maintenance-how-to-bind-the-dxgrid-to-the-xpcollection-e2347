using System;
using System.Windows;
using Northwind;
using DevExpress.Xpo;
using System.ComponentModel;

namespace XPCollectionSample {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 :Window {
        public Window1() {
            InitializeComponent();
            vm = new MyViewModel();
            DataContext = vm;
           
        }
        MyViewModel vm;
   

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            vm.Close();
        }
    }

    public class MyViewModel {
        public MyViewModel() {
            LoadData();
        }
        Session session;
        public XPCollection<Order> Orders { get; set; }
        private void LoadData() {
            session = new Session();
            Orders = new XPCollection<Order>(session);
            Orders.DeleteObjectOnRemove = true;
            Orders.DisplayableProperties = "ShipName;ShipAddress";
        }

        public void Close() {
            if (Orders != null) {
                Orders.Dispose();
                Orders = null;
            }
        }
    }
}
