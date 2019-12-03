using FinalProject.Infrastructure;
using FinalProject.Interface;
using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.ViewModel
{
    class MainViewModel : BaseNotify
    {
        private ObservableCollection<Car> cars = new ObservableCollection<Car>();
        private Car selectedCar;
        private ISaver saver;
        private ILoader loader;
        private string _searchStringFilter;
        public MainViewModel(ISaver saver, ILoader loader)
        {
            this.saver = saver;
            this.loader = loader;
        }

        public ICollectionView CarsView { get; set; }
        public string SearchCar
        {
            get => _searchStringFilter;
            set
            {
                _searchStringFilter = value;
                Notify(nameof(SearchCar));
                CarsView.Refresh();
            }
        }

        public ObservableCollection<Car> Movies
        {
            get => cars;
            set
            {
                cars = value;
                Notify();
            }
        }

        public Car SelectedMovie
        {
            get => selectedCar;
            set
            {
                selectedCar = value;
                SingletonSelect.Car = value;
                Notify();
            }
        }
    }
}