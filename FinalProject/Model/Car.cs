using FinalProject.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    class Car : BaseNotify
    {
        private string title;
        private int year;
        private int rating;
        private string colour;
        private string image;
        private string cars;
        private string about;

        public string Image
        {
            get => image;
            set
            {
                image = value;
                Notify();
            }
        }

        public string About
        {
            get => about;
            set
            {
                about = value;
                Notify();
            }
        }

        public int Year
        {
            get => year;
            set
            {
                year = value;
                Notify();
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                Notify();
            }
        }

        public string Colour
        {
            get => colour;
            set
            {
                colour = value;
                Notify();
            }
        }

        public int Rating
        {
            get => rating;
            set
            {
                rating = value;
                Notify();
            }
        }

        public string Cars
        {
            get => cars;
            set
            {
                cars = value;
                Notify();
            }
        }

        public ObservableCollection<Car> GetCars()
        {
            return new ObservableCollection<Car>
            {
                new Car { Title = "",Cars="", Year=2017, Colour = "", Rating=5, Image=@"..\image\1.jpg",About=""},
                new Car { Title = "",Cars="", Year=2018, Colour = "", Rating=4, Image=@"..\image\1.jpg",About=""},
            };
        }



    }

}
