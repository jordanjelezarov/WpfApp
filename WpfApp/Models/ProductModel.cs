using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class ProductModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int productId;
        private string productName;
        private decimal unitPrice;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (productId != value)
                {
                    productId = value;
                    NotifyPropertyChanged("ProductId");
                }
            }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (productName != value)
                {
                    productName = value;
                    NotifyPropertyChanged("ProductName");
                }
            }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (unitPrice != value)
                {
                    unitPrice = value;
                    NotifyPropertyChanged("UnitPrice");
                }
            }
        }

        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
