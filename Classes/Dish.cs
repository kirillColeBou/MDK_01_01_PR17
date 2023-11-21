using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pizza_Тепляков.Classes
{
    public class Dish
    {
        public uint id;
        public string name;
        public List<Sizes> sizes = new List<Sizes>();
        public string img;
        public List<Ingredient> ingredients = new List<Ingredient>();
        public string description;

        public uint activeSize = 0;

        public class Sizes
        {
            public uint id;
            public uint id_size;
            public uint size;
            public uint price;
            public uint weight;
            public uint countOrder;
            public bool orders;
        }

        public class Ingredient
        {
            public uint id;
            public string name;
            public uint weight;
            public uint price;
            public string img;
            public uint count;
        }
    }
}
