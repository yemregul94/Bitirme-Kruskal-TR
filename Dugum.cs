namespace KruskalProjesi
{
    class Dugum
    {          
        int dugumİsim;
        public int dugumSeviye;
        public Dugum kok;
        public System.Drawing.Point konum;

        public int İsim
        {
            get
            {
                return dugumİsim;
            }
        }

        public Dugum(int dugumİsim, System.Drawing.Point konum)
        {
            this.dugumİsim = dugumİsim;
            dugumSeviye = 0;
            this.kok = this;
            this.konum = konum;
        }

        public Dugum KokBul()
        {
            if (this.kok != this) 
            {
                this.kok = this.kok.KokBul(); 
            }
            return this.kok;
        }

        public static void KokBirlestir(Dugum kok1, Dugum kok2)
        {

            if (kok2.dugumSeviye < kok1.dugumSeviye)
            {
                kok2.kok = kok1;
            }
            else 
            {
                kok1.kok = kok2;
                if (kok1.dugumSeviye == kok2.dugumSeviye)
                {
                    kok1.dugumSeviye++;
                }
            }
        }
     
    }
}
