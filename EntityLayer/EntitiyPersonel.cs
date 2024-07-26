using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitiyPersonel
    {
        int id;
        string name;
        string surname;
        string city;
        string mision;
        short wage;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public string Mision { get => mision; set => mision = value; }
        public short Wage { get => wage; set => wage = value; }
    }
}
