using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace planner
{
    public class Note {
        public DateTime date;
        public string desc;
        public string bigdesc;
    }
    internal class Program
    {
        static DateTime datenow = new DateTime(2023, 7, 20);
        static List<Note> NoteList = new List<Note>(); 

        static void Cursor() {
            int position = 1;
           
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position > 1)
                {
                    position--;
                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Menu(key, position);


            }
            Desc(position);

        

        }
        static void Menu(ConsoleKeyInfo key, int position)
        {
            
            if (key.Key == ConsoleKey.RightArrow)
            {
                
                Console.Clear();
                datenow = datenow.AddDays(1);
                Console.SetCursorPosition(0,0);
                Console.WriteLine("Date" + datenow);
                int i = 1;
                foreach (Note pos in NoteList)
                {
                    
    
                    
                    if (pos.date.Date == datenow.Date)
                    {
                       
                        
                        
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("  " + pos.desc);
                        i++;
                       

                    }


                }
            }

            else if (key.Key == ConsoleKey.LeftArrow)
            {

                Console.Clear();
                datenow = datenow.AddDays(-1);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Date" + datenow);
                int i = 1;
                foreach (Note pos in NoteList)
                {
                   
                    if (pos.date.Date == datenow.Date)
                    {
                        
                        
                        Console.SetCursorPosition(0,i);
                        Console.WriteLine("  " + pos.desc);
                        i++;




                    }


                }
            }

        }

        static void Desc(int position) {
            Console.Clear();
            int i = 1;
            foreach (Note pos in NoteList)
            {
               
                if (pos.date.Date == datenow.Date)
                {
                    if (i == position) {
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("  " + pos.bigdesc);

                    }
                    i++;

                }
                

            }


        }


        static void Main(string[] args)
        {    
            Note colledge = new Note();
            colledge.date = new DateTime(2023, 7, 20, 18, 30, 25);
            colledge.desc = "Сходить сегодня в колледж";
            colledge.bigdesc = "Сходить сегодня в колледж и исправить все свои косяки";

            Note drawing = new Note();
            drawing.date = new DateTime(2023, 7, 23, 18, 30, 25);
            drawing.desc = "Нарисовать какую-нибудь ерунду";
            drawing.bigdesc = "Нарисовать какую-нибудь ерунду";

            Note homework = new Note();
            homework.date = new DateTime(2023, 7, 22, 18, 30, 25);
            homework.desc = "Сделать домашку";
            homework.bigdesc = "Сделать домашку";

            Note walking = new Note();
            walking.date = new DateTime(2023, 7, 22, 18, 30, 25);
            walking.desc = "Выйти на прогулку";
            walking.bigdesc = "Выйти на прогулку";


            NoteList.Add(colledge);
            NoteList.Add(walking);
            NoteList.Add(homework);
            NoteList.Add(drawing);
            while (true)
            {
                Cursor();
            }
        }
    }
}