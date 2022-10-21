using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        public string AD  { get => ad; set => ad = value; }

        private string soyad;
        public string SOYAD { get => soyad; set => soyad = value; }

        private int id;
        public int ID { get => id; set => id = value; }

        private string numara;
        public string NUMARA { get => numara; set => numara = value; }

        private string fotograf;
        public string FOTOGRAF { get => fotograf; set => fotograf = value; }

        private string bakiye;
        public string BAKIYE { get => bakiye; set => bakiye = value; }

    }
}
