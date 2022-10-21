using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtadsoyad;
        private string ogrtbrans;

        public int OGRTID { get => ogrtid; set => ogrtid = value; }
        public string OGRTADSOYAD { get => ogrtadsoyad; set => ogrtadsoyad = value; }
        public string OGRTBRANS { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
