using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubgames.Properties
{

    class Person
    {
        string name;
        private int age;

        public Person ()
        {

        }
        public Person(string nameParameter)
            {
                name = nameParameter;
            }
        public void SetName(string nameParameter)
            {
                name = nameParameter;
            }
        public string GetName()
            {
                return name;
            }
        public void SetAge()
        {
            Random r = new Random();
            age = r.Next(16, 18);
        }
        public int GetAge()
        {
            return age;
        }

    }

}
