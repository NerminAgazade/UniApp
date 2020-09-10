using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_proqraming
{
    class Students
    {
        public string FullName { get; set; }
        public int Id { get;private set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public List<Groups>Group{ get; set; }
        private static int stuId = 1;
     
        public Students(string Fullname)
        {
            this.FullName = FullName;
        }
        public Students(string FullName, string Email, int Phone)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.Phone = Phone;
            stuId++;
        }
    }
}
