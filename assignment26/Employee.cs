using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment26
{
   
    
        // Step 1: Create a Class
        [Serializable]
        public class Employee
        {
            // Properties of the Employee class
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
        }
    
}
