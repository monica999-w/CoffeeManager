using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Interfaces
{
    public interface ICoffee
    {
        public int BlackCoffee { get; set; }
        public int Sugar { get; set; }
        public List<IMilk> Milk { get; set; }


    }
}
