using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg2Singleton
{
    class Baglantı
    {
        private Baglantı()
        {

        }
        static Baglantı b;
        static Baglantı()
        {
            b = new Baglantı();

        }

        public static Baglantı BaglantıDönder()
        {
            return b;
        }
    }
}
