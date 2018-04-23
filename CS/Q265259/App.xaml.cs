using System;
using System.Windows;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace Q265259 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App :Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            InitializeDataLayer();
        }

        private void InitializeDataLayer() {
            XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString(@"..\..\nwind.mdb");
        }
    }
}
