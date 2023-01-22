using System;

namespace ToDoList
{
    class Program
    {
        public static void Main(string[] args)
        {
            int yapilanIslem = 0;

            do
            {
                System.Console.WriteLine("(1) Kart oluştumak için");
                System.Console.WriteLine("(2) Kart silmek için");    
                System.Console.WriteLine("(3) Kartlari görüntelmek için");    
                System.Console.WriteLine("(0) Çikiş");
                System.Console.WriteLine("Lütfen yapmak istediğiniz islemi seçiniz");
                yapilanIslem = int.Parse(Console.ReadLine());

                switch (yapilanIslem)
                {
                    
                    case 1: ToDoList.KartOlustur();break;
                    case 2: ToDoList.KartSilme();break;
                    case 3: ToDoList.KartlariGörüntüle();break;
                    case 0: yapilanIslem = 0; break;
                    default : System.Console.WriteLine("Lütfen 1 - 4 dahil arasi değerler giriniz"); break;
                }            

            } while (yapilanIslem != 0);
        }
    }
}
