using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Interfaces
{
   public interface ICoffeeMaker
   {
        public void MakeCoffee(ICoffee coffee);
        public void AddMoreMilk(ICoffee coffee, IMilk milk);
        public void AddMoreSugar(ICoffee coffee, int countSugar);
        public string OrderInfo(ICoffee coffee);

   }
}
