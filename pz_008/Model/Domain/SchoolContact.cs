using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_008.Model.Domain
{
    internal class SchoolContact : IContact
    {
        public string Name { get; }

        public long Phone { get; }
        public string Adress { get; }
        public string Specialization { get; }
        public int StudentCount { get; }

        public SchoolContact(string name, long phone, string adress, string specialization, int studentCount)
        {
            Name = name;
            Phone = phone;
            Adress = adress;
            Specialization = specialization;
            StudentCount = studentCount;

        }

        public string[] GetInfo()
        {
            return new string[5] { Name, Phone.ToString(), Adress, Specialization, StudentCount.ToString() }; 
        }
    }
}
