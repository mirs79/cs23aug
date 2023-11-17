using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPostgre
{
    class Actor
    {
        public int actor_id;
        public String first_name;
        public String last_name;
        public DateTime last_update;

        public override string ToString()
        {
            return last_name+" "+ first_name;
        }
    }
}
