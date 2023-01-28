using System;
using System.Collections.Generic;
using System.Text;

namespace lab6ex1
{
    class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public int getVolumn()
        {
            return lungime * latime * inaltime;
        }
    }
}
