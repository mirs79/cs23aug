using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsRead
{
    class Composer
    {
      public  String composer_id, last_name, death_date, death_place;

        public override string ToString()
        {
            return composer_id+" "+last_name + " " + death_date + " " + death_place;
        }
    }
}
