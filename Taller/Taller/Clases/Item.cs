using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    class Item
    {
        private int id;
        private string name;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Item(int _id, string _name, string _description)
        {
            Id = _id;
            Name = _name;
            Description = _description;
        }
    }
}
