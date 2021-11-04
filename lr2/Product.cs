using System;
using System.Collections.Generic;
using System.Text;

namespace lr2
{
    class Product
    {
        public String name;
        public String proizvoditel;
        public String code;
        public String price;
        public Nalichie nalichie;
        public Otdel otdel;
    }
    
    public enum Nalichie { est, net}

    public enum Otdel { molochni, myasnoi, hlebobul, alcogolni, lichgig }
}
