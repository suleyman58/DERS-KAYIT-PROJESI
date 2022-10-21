using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuru
    {
        private int basvuruid;
        private int basogrid;
        private int basdersid;

        public int BASVURUID { get => basvuruid; set => basvuruid = value; }
        public int BASOGRID { get => basogrid; set => basogrid = value; }
        public int BASDERSID { get => basdersid; set => basdersid = value; }
    }
}
