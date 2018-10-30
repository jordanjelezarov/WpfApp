using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _productId;
        private ProductModel currentProduct;
        private ICommand getProductCommand;
        private ICommand saveProductCommand;

        public ProductModel CurrentProduct
        {
            get { return currentProduct; }
            set
            {
                if (value != currentProduct)
                {
                    currentProduct = value;
                    NotifyPropertyChanged("CurrentProduct");
                }
            }
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if (saveProductCommand == null)
                {
                    saveProductCommand = new RelayCommand(
                        param => SaveProduct(),
                        param => (CurrentProduct != null)
                    );
                }
                return saveProductCommand;
            }
        }

        public ICommand GetProductCommand
        {
            get
            {
                if (getProductCommand == null)
                {
                    getProductCommand = new RelayCommand(
                        param => GetProduct(),
                        param => ProductId > 0
                    );
                }
                return getProductCommand;
            }
        }

        public int ProductId
        {
            get { return _productId; }
            set
            {
                if (value != _productId)
                {
                    _productId = value;
                    NotifyPropertyChanged("ProductId");
                }
            }
        }


        private void GetProduct()
        {
            // You should get the product from the database
            // but for now we'll just return a new object
            ProductModel p = new ProductModel();
            p.ProductId = ProductId;
            p.ProductName = "Test Product";
            p.UnitPrice = 10;
            CurrentProduct = p;
        }

        private void SaveProduct()
        {
            // You would implement your Product save here
        }


        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
