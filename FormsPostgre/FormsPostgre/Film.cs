using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPostgre
{
    class Film
    {
        public int film_id;
        public String title;
        public int release_year;

        public override string ToString()
        {
            return title + " " + release_year;
        }
    }
}
