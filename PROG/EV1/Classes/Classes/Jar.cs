using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Jar
    {
        private double capacity;
        private double quantity;
        public double Setquantity(double value)
        {
            if(quantity < 0)
                quantity = 0;
            if(quantity > capacity)
            {
                quantity = capacity;
                return value - capacity;
            }
            else 
                quantity = value;
            return 0;
        }
        public double GetQuantity()
        {
            return quantity;
        }
        public void SetCapacity(double value)
        {
            quantity = value;
        }
        public double GetCapacity()
        {
            return capacity;
        }
        public double GetPercent()
        {
            if(capacity == 0)
                return 0;
            return quantity / capacity;
        }
        public double Remain()
        {
            return capacity - quantity;
        }
        public double AddQuantity(double value)
        {
            return Setquantity(quantity + value);  
            
        }



    }
}
