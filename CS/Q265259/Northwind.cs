using System;
using DevExpress.Xpo;
namespace Northwind {

    [Persistent("Products")]
    public class Product :XPLiteObject {
        int fProductID;
        [Key(true)]
        public int ProductID {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        string fQuantityPerUnit;
        [Size(20)]
        public string QuantityPerUnit {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>("QuantityPerUnit", ref fQuantityPerUnit, value); }
        }
        decimal fUnitPrice;
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }
        short fUnitsInStock;
        public short UnitsInStock {
            get { return fUnitsInStock; }
            set { SetPropertyValue<short>("UnitsInStock", ref fUnitsInStock, value); }
        }
        public Product(Session session) : base(session) { }
        public Product() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
