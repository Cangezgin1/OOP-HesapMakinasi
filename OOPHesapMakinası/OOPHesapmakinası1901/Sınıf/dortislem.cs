
namespace Sınıf
{
    public class dortislem:System.IDisposable
    {
        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }

        public int sayi1;
        public int sayi2;
        public string islemtipi;
        public int sonsonuc;

        public dortislem(int sayi1, int sayi2, string islemtipi)
        {
            int sonuc = 0;
            switch (islemtipi)
            {
                case "Toplama":
                    sonsonuc = sayi1 + sayi2;
                    break;
                case "Çıkarma":
                    if (sayi1 > sayi2)
                    {
                        sonsonuc = sayi1 - sayi2;
                    }
                    else
                        sonsonuc = sayi2 - sayi1;
                    break;
                case "Çarpma":
                    sonsonuc = sayi1 * sayi2;
                    break;
                case "Bölme":
                    if (sayi1 != 0)
                    {
                        sonsonuc = sayi1 / sayi2;
                    }
                    else
                        sonsonuc = 0;
                    break;
                default:
                    break;
            } 
        }
    }

    #region Ek İşlem
    public class Toplafaktöriyel : System.IDisposable
    {
        public int fakt = 1;
        int topla = 0;
        public int s1;
        public int s2;

        public Toplafaktöriyel(int _sayi1, int _sayi2)
        {
            this.s1 = _sayi1;
            this.s2 = _sayi2;
            topla = s1 + s2;
            for(int i=1; i<=topla; i++)
            {
                fakt = fakt * i;
            }
        }
        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }
    }
    #endregion
}
