using System.Collections.Generic;

namespace KruskalProjesi
{
    class Kenar
    {           
        Dugum dugum1, dugum2;
        int maliyet;
        System.Drawing.Point yaziKonum;
        
        public Dugum Dugum1
        {
            get
            {
                return dugum1;
            }
        }

        public Dugum Dugum2
        {
            get
            {
                return dugum2;
            }
        }

        public int Maliyet
        {
            get
            {
                return maliyet;
            }
        }

        public System.Drawing.Point YaziKonum
        {
            get
            {
                return yaziKonum;
            }
        }
 
        public Kenar(Dugum dugum1, Dugum dugum2, int maliyet, System.Drawing.Point yaziKonum)
        {
            this.dugum1 = dugum1;
            this.dugum2 = dugum2;
            this.maliyet = maliyet;
            this.yaziKonum = yaziKonum;
        }

        public int Kiyasla(object obj)
        {
            Kenar k = (Kenar)obj;
            return this.maliyet.CompareTo(k.maliyet);
        }

        internal static void QuickSort(List<Kenar> kenarListe, int solSayi, int sagSayi)
        {
            int i, j, x;
            i = solSayi; j = sagSayi;
            x = kenarListe[(solSayi + sagSayi) / 2].Maliyet;

            do
            {
                while ((kenarListe[i].Maliyet < x) && (i < sagSayi)) i++;
                while ((x < kenarListe[j].Maliyet) && (j > solSayi)) j--;

                if (i <= j)
                {
                    Kenar y = kenarListe[i];
                    kenarListe[i] = kenarListe[j];
                    kenarListe[j] = y;
                    i++; j--;
                }
            } while (i <= j);

            if (solSayi < j) QuickSort(kenarListe, solSayi, j);
            if (i < sagSayi) QuickSort(kenarListe, i, sagSayi);
        }
    }
}
