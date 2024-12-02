using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
        //member variable
        //private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        //property

        //public string Model { get => _model; set => _model = value; }

        /*as we are not changing anything or giving any condition to get or set in Model, we 
        can simplify it in the following way and remove member variable of it. this property
        model will work just like a variable. */

        public string Model { get; set; } //we do not need a backing field, such as member variable(_model)


        public string Brand {

            get //this will pass the default value
            { 
                if (_isLuxury)
                {

                return _brand + " luxury brand"; 
                }
                else
                    
                { 
                    return _brand;
                }
            }
            set
            {
                //this will check if no null, will set the new value in the private variable and pass

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("empty input");
                    _brand = "null";
                }

                else
                {
                    _brand = value;
                }
                
            
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }


        //constructor
        public Car(string modelName, string brand, bool isLuxuryBrand)
        {

            Model = modelName;
            Brand = brand;
            IsLuxury = isLuxuryBrand;

            Console.WriteLine("created car of model " + Model + " of brand " + Brand);
        }

        //method

        public void Drive()
        {
            Console.WriteLine("the car is " + Model+ " of brand " + Brand+ " is driving");
        }
    }
}
