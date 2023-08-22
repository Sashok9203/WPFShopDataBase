using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPFShopDataBase.Data;
using WPFShopDataBase.Entities;

namespace WPFShopDataBase.Models
{
    internal class ShopDBModel :IDisposable, INotifyPropertyChanged
    {
        private bool disposedValue;

        private Shop? selectedShop;

        private ShopDbContext dbContext;

        public ShopDBModel() { dbContext = new();}

        public Shop? SelectedShop
        {
            get => selectedShop;
            set 
            {
                selectedShop = value;
                OnPropertyChanged("Workers");
                OnPropertyChanged("Products");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)  dbContext.Dispose();
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Worker>? Workers => SelectedShop?.Workers;

        public IEnumerable<Product>? Products => SelectedShop?.Products;

        public IEnumerable<Shop> Shops => dbContext.Shops.Include(x => x.Workers).ThenInclude(x => x.Position)
                                                         .Include(x => x.Products).ThenInclude(x => x.Category)
                                                         .Include(x => x.City).ThenInclude(x => x.Country);
    }
}
