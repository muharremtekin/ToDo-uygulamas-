using System;
using System.Collections.Generic;
namespace ToDo_Uygulaması
{
    public static class metotlar
    {
        enum Sizes
        {
            XS = 1, S, M, L, XL
        }
        public static void BoardAdd()
        {
            Console.Write("BAŞLIK GİRİNZ: ");
            string baslik = Console.ReadLine();
            Console.Write("İÇERİK GİRİNİZ");
            string icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)");
            byte sizeIndex = byte.Parse(Console.ReadLine());
            Console.Write("Kişi seçiniz: ");
            byte memberIndex = byte.Parse(Console.ReadLine());
            ToDo.duty.Add(new Board(baslik, icerik, opSize(sizeIndex), memberSelect(memberIndex)));
        }

        //görev boyutunu bulur.
        public static string opSize(byte a)
        {
            string hata = "Hatalı giriş yaptınız!";
            if (a == 1)
                return Sizes.XS.ToString();
            else if (a == 2)
                return Sizes.S.ToString();
            else if (a == 3)
                return Sizes.M.ToString();
            else if (a == 4)
                return Sizes.L.ToString();
            else if (a == 5)
                return Sizes.XL.ToString();
            else
                return hata;
        }

        public static void boardDelete()
        {
            bool control = false;
            while (control == false)
            {
                Console.WriteLine("Silmek istediğiniz kartın başlığını yazınız");
                string baslik = Console.ReadLine().ToLower();
                foreach (var item in BoardDictionary.BoardDicList)
                {
                    foreach (var item2 in item.Value)
                    {
                        if (item2.Baslik.ToLower() == baslik.ToLower())
                        {
                            Console.WriteLine("Kart bulundu, siliniyor...");
                            item.Value.Remove(item2);
                            control=true;
                            break;
                        }
                    }
                }

                if (control == false)
                {
                    byte check = 0;
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    check = byte.Parse(Console.ReadLine());
                    if (check == 1)
                    {
                        control=false;
                    }
                }
            }
        }
        //listeleme yapar
        public static void boardList(List<Board> a, List<Board> b, List<Board> c)
        {
            // a = ToDo list, b= InProgress list, c= Done list.
            // ToDo line listing.
            for (byte i = 0; i < a.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("TODO LİNE \n*******************************");
                    Console.WriteLine($"BAŞLIK: {a[i].Baslik} \nİÇERİK: {a[i].Icerik} \nAtanan kişi: {a[i].AtananKisi} \nGörev büyüklüğü: {a[i].Buyukluk}");
                }
                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"BAŞLIK: {a[i].Baslik} \nİÇERİK: {a[i].Icerik} \nAtanan kişi: {a[i].AtananKisi} \nGörev büyüklüğü: {a[i].Buyukluk}");
                }
            }
            // In progress line listing
            for (byte i = 0; i < b.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\n\n\n\nIN PROGRESS LİNE \n*******************************");
                    Console.WriteLine($"BAŞLIK: {b[i].Baslik} \nİÇERİK: {b[i].Icerik} \nAtanan kişi: {b[i].AtananKisi} \nGörev büyüklüğü: {b[i].Buyukluk}");
                }
                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"BAŞLIK: {b[i].Baslik} \nİÇERİK: {b[i].Icerik} \nAtanan kişi: {b[i].AtananKisi} \nGörev büyüklüğü: {b[i].Buyukluk}");
                }
            }
            // Done line
            for (int i = 0; i < c.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\n\n\n\nIN PROGRESS LİNE \n*******************************");
                    Console.WriteLine($"BAŞLIK: {c[i].Baslik} \nİÇERİK: {c[i].Icerik} \nAtanan kişi: {c[i].AtananKisi} \nGörev büyüklüğü: {c[i].Buyukluk}");
                }
                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"BAŞLIK: {c[i].Baslik} \nİÇERİK: {c[i].Icerik} \nAtanan kişi: {c[i].AtananKisi} \nGörev büyüklüğü: {c[i].Buyukluk}");
                }
            }
        }
        public static string memberSelect(byte id)
        {
            string appointedPerson = null;
            for (byte i = 0; i < members.m.Count; i++)
            {
                if (byte.Parse(members.m[i].Id) == id)
                {
                    appointedPerson = $"{members.m[i].Name} {members.m[i].Surname}";
                }
            }
            return appointedPerson;
        }
    }
}