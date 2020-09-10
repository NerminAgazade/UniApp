using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_proqraming
{
    class Teachers
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public List<Students> Students{ get; set; }
        private static int stuId = 1;
        public Teachers(string FullName)
        {
            this.FullName = FullName;
            this.Id = stuId;
            stuId++;
        }
    }
}
