using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MypersonClass
{
    internal class Person
    {
        private string Name1;
        private string Name2;

        public string FirstName
        {
            get
            {
                return Name1;
            }
            set
            {
                Name1 = value;
            }
        }
        public string LastName
        {
            get
            {
                return Name2;
            }
            set
            {
                Name2 = value;
            }
        }


        public int Age(DateTime Birthday)
        {
            //System.DateTime date1 = DateTime.Now;
            //DateTime date2 = Birthday;
            //System.TimeSpan age = date1.Subtract(date2);
            //double age1 = Convert.ToDouble(age.Days) / 365.25;
            //int age2 = Convert.ToInt32(age1);
            //return(age2);
            return Convert.ToInt32(DateTime.Now.Subtract(Birthday).Days / 365.25);
        }

    }
}
