using System;
using System.Collections.Generic;
using TomasFeeney_S00188023;

namespace DataManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
            }

        }
    }
}
