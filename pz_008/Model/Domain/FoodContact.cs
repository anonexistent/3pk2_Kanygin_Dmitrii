using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_008.Model.Domain
{
    internal class FoodContact : IContact
    {
        public string Name { get; }
        public long Phone { get; }
        public string Address { get; }
        public string Description { get; }
        public string[] Menu { get; }

        public FoodContact(string name, long phone, string adrecc, string description, string[] menu)
        {
            Name = name;
            Phone = phone;
            Address = adrecc;
            Description = description;
            Menu = menu;
        }

        public string[] GetInfo()
        {
            return new string[5] { Name, Phone.ToString(), Address, Description, string.Join('—', Menu) };
        }
    }
}
