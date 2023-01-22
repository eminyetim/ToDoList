using System;

namespace ToDoList
{
    public static class ToDoList
    {
        public static List<KartIcerik> my_list = new List<KartIcerik>();
        public static void KartOlustur()
        {

            System.Console.WriteLine("Lütfen Başlik Giriniz :");        
            string gelen_baslik = Convert.ToString(Console.ReadLine());


            System.Console.WriteLine("Lütfen İçerik Giriniz :");
            string gelen_icerik = Convert.ToString(Console.ReadLine());

            System.Console.WriteLine("Lütfen gelen kişiyi giriniz :");
            string gelen_atananKisi = Convert.ToString(Console.ReadLine());

            System.Console.WriteLine("Lütfen Büyüklük Sayisini Giriniz : XS(1),S(2),M(3),L(4),XL(5)");
            int gelen_buyukluk  = int.Parse(Console.ReadLine());
           
            KartIcerik temp = new KartIcerik();
            temp.Baslik1 = gelen_baslik;
            temp.Icerik1 = gelen_icerik;
            temp.AtananKisi = gelen_atananKisi;
            temp.Buyukluk1 = gelen_buyukluk;

            my_list.Add(temp);            
        }

        public static void KartSilme()
        {
            System.Console.WriteLine("Lütfen silinecek basliği giriniz :");
            string silincekBaslik = Console.ReadLine();

            bool bulundumu = false;
            foreach (var item in my_list)
            {
                if(item.Baslik1 == silincekBaslik)
                {
                    my_list.Remove(item);
                    bulundumu = true;
                    break;
                }
            }
            if(bulundumu)
                System.Console.WriteLine("Değer Bulundu " + silincekBaslik);
            else
            {
                System.Console.WriteLine("Tekrar silme işlemi yapmak için (1):");
                System.Console.WriteLine("Tekrar sonlandirmak için (2):");
                int gelen_islem = int.Parse(Console.ReadLine());
                if(gelen_islem == 1)
                {
                    KartSilme();
                }
            }

        }

        public static void KartlariGörüntüle()
        {
            System.Console.WriteLine("** Kartlarim **");
            foreach (var item in my_list)
            {
                System.Console.WriteLine("Baslik          :" + item.Baslik1 );
                System.Console.WriteLine("İcerik          :" + item.Icerik1 );
                System.Console.WriteLine("AtananKisi      :" + item.AtananKisi );
                System.Console.WriteLine("Büyüklük        :" + item.Buyukluk1);
                System.Console.WriteLine();
            }
        }
    }
  
}