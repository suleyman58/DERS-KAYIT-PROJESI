using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BlldersListeleme()
        {
            return DALDersler.dersListesi();

        }
        public static int talepeklebll(EntityBasvuru p)
        {
            if (p.BASOGRID >=0 && p.BASDERSID >= 0)
            {
                return DALDersler.talepekle(p);

            }
            return -1;

        }
    }
}
