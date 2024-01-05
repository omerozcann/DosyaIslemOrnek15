using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] veriler = File.ReadAllLines("kayitlar.txt",Encoding.Default);
            foreach (var item in veriler)
            {
                String[] dizi = item.Split(';');
                //split komutu ile veri ; karakterini kullanarak bölünür ve diziye dönüştürülür.
                Double arasinav =Convert.ToDouble( dizi[2]);
                Double final = Convert.ToDouble(dizi[3]);
                Double ortalama = arasinav * 0.4 + final * 0.6;
                Console.WriteLine(dizi[0] + " "+dizi[1] + " " + dizi[2] + " " + dizi[3] + " " + ortalama);
            }
        }
    }
}
