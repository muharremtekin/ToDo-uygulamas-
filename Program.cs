using System;

namespace ToDo_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            teamMember.memberAdd(); //takım üyeleri ekleniyor
            // 3 board ekleniyor
            InProgress.duty2.Add(new Board("QWERTY","BBB",metotlar.memberSelect(16),metotlar.opSize(3)));
            ToDo.duty1.Add(new Board("QWERTY","AAA",metotlar.memberSelect(15),metotlar.opSize(1)));
            done.duty3.Add(new Board("QWERTY","CCC",metotlar.memberSelect(14),metotlar.opSize(2)));

            
            
            bool control=true;
            while(control==true)
            {
                metotlar.startPrint();
                byte select = byte.Parse(Console.ReadLine());
                if(select == 1)
                {
                    metotlar.boardList(ToDo.duty1,InProgress.duty2,done.duty3);
                    control=false;
                }
                if(select == 2)
                {
                    metotlar.BoardAdd();
                    control=false;
                }
                else if (select == 3)
                {
                    metotlar.boardDelete();
                    control=false;
                }
                else if (select==4)
                {
                    metotlar.moveCard();
                    control=false;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş!");
                    control=false;
                }
            }
        }
    }
}
