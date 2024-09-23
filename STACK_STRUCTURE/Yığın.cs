using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_STRUCTURE
{
    public class Yığın<T>
    {
        private T[] öğeler;
        private int yığın_boyut;

        public Yığın(int boyut)
        {
            öğeler = new T[boyut];
             yığın_boyut = -1;
        }

        public void ekle(T item)
        {
            if (yığın_boyut == öğeler.Length)
            {
                Console.WriteLine("Yığın kapasitesi doludur.Eleman eklenemiyor.");
            }
            else
            {
                öğeler[++yığın_boyut] = item;
                Console.WriteLine(item + " Yığın yapısına eleman eklenmiştir...");
            }

        }

        public T çıkar ()
        {
            if (yığın_boyut == -1)
            {
                Console.WriteLine("Yığın boştur.Eleman çıkarılamıyor.");
                return default(T);
            }
            else
            {
                T item = öğeler[--yığın_boyut];
                Console.WriteLine(item + " Yığından çıkartıldı...");
                return item;
                
            }
        }
        public T en_üstteki_eleman()
        {
            if (yığın_boyut == -1)
            {
                Console.WriteLine("Yığın boştur");
                return default(T);
            }
            else
            {
                return öğeler[yığın_boyut];
            }
        }
        public bool boş_Mu()
        {

            return yığın_boyut==-1;
        }
        public void temizle()
        {
            while(!boş_Mu())
            {
                çıkar();
            }
        }
        public void yazdır()
        {
            if (!boş_Mu())
            {
                foreach (var item in öğeler)
                {
                    Console.WriteLine(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Yığın yapısı boştur...");
            }
         
        }

    }


}
    

