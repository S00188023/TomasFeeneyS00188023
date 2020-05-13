using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomasFeeney_S00188023
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        /*
        public static void IncreasePrice
        {
            int percentage;
        }
        */
        public virtual List<Phone> Phones { get; set; }

        public class PhoneData : DbContext
        {
            public PhoneData() : base("MyPhoneData") { }
            public DbSet<Phone> Phones { get; set; }
        }

        //public List<Phone> Phones { get; set; }

        //public class 
    }
}
