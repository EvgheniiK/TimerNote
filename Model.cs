using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;


namespace TimerNote
{
    public class Model
    {
        public static Stopwatch stopWatch = new Stopwatch();

        public static List<TimeSpan> Mlist = new List<TimeSpan>();
        public static List<DateTime> listOfDataNow = new List<DateTime>();



        public void Reset2() { stopWatch.Reset(); }
        public DateTime Start2()
        {
            DateTime dt = DateTime.Now;
            listOfDataNow.Add(dt);
            stopWatch.Start();
            return listOfDataNow[0];

        }

        public void RsetlistOfDataNow() { listOfDataNow.Clear(); }


        public string Tick2()
        {
            TimeSpan tempTimeSpan = stopWatch.Elapsed;

            string timeSpanText = Convert.ToString(tempTimeSpan.Hours) + "час " + Convert.ToString(tempTimeSpan.Minutes) + "мин " + Convert.ToString(tempTimeSpan.Seconds) + "сек";

            return timeSpanText;
        }

        public DateTime InToCollection()
        {
            TimeSpan temp = stopWatch.Elapsed;
            Mlist.Add(temp);

            DateTime fromStartTame = Start2();

            fromStartTame = fromStartTame + temp;
            return fromStartTame;
        }


        public string GetTimeSpan()
        {
            TimeSpan temp2 = new TimeSpan();
            // Mlist.Reverse();
            foreach (var item in Mlist)
            {
                temp2 += item;
            }
            return temp2.ToString(@"hh\:mm\:ss");
        }


        // DataTi.Add(dt);


        //для фомирования строки
        /*  var builder = new StringBuilder();

          builder.Append("StringBuilder ").Append("является ").Append("очень ... ");

          string build1 = builder.ToString();*/

        //  string build1 = builder.ToString();*/


        /*    string OutCilection()
            {

                string temp2 = Convert.ToString(timeSpans[0].Hours) + "час " + Convert.ToString(timeSpans[0].Minutes) + "мин " + Convert.ToString(timeSpans[0].Seconds) + "сек";


                return temp2;

            }*/


        #region

        /*    public IEnumerable Collect()
            {
                TimeSpan temp = stopWatch.Elapsed;
                collection.Push(temp);

                foreach (var item in collection)
                {
                    yield return item.ToString();


                }


            }*/
        /*      Library Li = new Library();
              *//*    public class ggg {

                       UserCollection<TimeSpan> сollection2 = new UserCollection<TimeSpan>();
                       TimeSpan temp = stopWatch.Elapsed;


                       сollection2 = collection.Push(temp);

                       сollection[1] = new Element(3, 4);
                       сollection[2] = new Element(5, 6);
                       сollection[3] = new Element(7, 8);

                       //В циклической конструкции foreach выводим содержимое коллекции на экран.
                       foreach (Element element in сollection)
                       {
                           Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
                       }

                   }


                   public IEnumerator GetEnumerator()
                   {
                       TimeSpan temp = stopWatch.Elapsed;
                       collection.Push(temp);

                       foreach (var item in collection)
                       {
                           yield return item.ToString();


                       }

                   }*//*
              public string Ggg()
              {
                  Li.
                  foreach (Book b in library)
                  {
                      return b.Name;
                  }
              }*/



        /*   class Book
           {
               public Book(TimeSpan name)
               {
                   this.Name = name;
               }
               public TimeSpan Name { get; set; }
           }

           class Library
           {
               private Book[] books;



               public Library()
               { 
                   TimeSpan temp = stopWatch.Elapsed;
                   books = new Book[] { new Book(temp) };
               }

               public int Length
               {
                   get { return books.Length; }
               }

               public IEnumerator GetEnumerator()
               {
                   for (int i = 0; i < books.Length; i++)
                   {
                       yield return books[i];
                   }
               }
           }
   */






        /*
                public class UserCollection<T>
                {
                    readonly T[] elements = new T[4];

                    public T this[int index]
                    {
                        get { return elements[index]; }
                        set { elements[index] = value; }
                    }



                    // Создаем метод GetEnumerator(), используем оператор yield.
                    public IEnumerator GetEnumerator()
                    {

                        foreach (var element in elements)
                        {
                            yield return element;
                        }*/

        /*     public IEnumerable Collect()
             {
                 TimeSpan temp = stopWatch.Elapsed;
                 collection.Push(temp);

                 foreach (var item in collection)
                 {
                     yield return item.ToString();


                 }




                       сollection2 = collection.Push(temp);

                       сollection[1] = new Element(3, 4);
                       сollection[2] = new Element(5, 6);
                       сollection[3] = new Element(7, 8);

                       //В циклической конструкции foreach выводим содержимое коллекции на экран.
                       foreach (Element element in сollection)
                       {
                           Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
                       }

                   }


                   public IEnumerator GetEnumerator()
                   {
                       TimeSpan temp = stopWatch.Elapsed;
                       collection.Push(temp);

                       foreach (var item in collection)
                       {
                           yield return item.ToString();


                       }

                   }*//*
              public string Ggg()
              {
                  Li.
                  foreach (Book b in library)
                  {
                      return b.Name;
                  }
              }*/



        /*      class Book
              {
                  public Book(TimeSpan name)
                  {
                      this.Name = name;
                  }
                  public TimeSpan Name { get ; set; }
              }

              class Library
              {
                  private Book[] books;

                  public void hh(TimeSpan temp ) 
                  {

                      books = new Book[] { new Book(temp) }; 
                  }

                  public Library()
                  { 

                  }

                  public int Length
                  {
                      get { return books.Length; }
                  }

                  public IEnumerator GetEnumerator()
                  {
                      for (int i = 0; i < books.Length; i++)
                      {
                          yield return books[i];
                      }
                  }
              }

      */






        /*      public class UserCollection<T>
              {
                  readonly T[] elements = new T[4];

                  public T this[int index]
                  {
                      get { return elements[index]; }
                      set { elements[index] = value; }
                  }



                  // Создаем метод GetEnumerator(), используем оператор yield.
                  public IEnumerator GetEnumerator()
                  {

                      foreach (var element in elements)
                      {
                          yield return element;
                      }


                  }
              }

      */










        /*        private int s;

                public string Tick()
                {
                    s++;
                    return s >= 60 ? (s / 60) + " min " + s % 60 + " sec" : "0 min " + s.ToString() + " sec ";
                    //return s >= 60 ? (s / 60) +""+ s % 60 + "":"" + s.ToString();


                 /*   return 
                            stopWatch.Stop();
                            TimeSpan temp = stopWatch.Elapsed; //!!!!!!!!!!!!!!!!!рабочаяя
                            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", temp.Hours, temp.Minutes, temp.Seconds);*/

        /*     }

             public void Reset()
             {
                 s = 0;
             }*/
        /*
         * 
         * для засечки времени
        TimeSpan s1 = TimeSpan.Parse("1:23");
        TimeSpan s2 = TimeSpan.Parse("0:54");
        TimeSpan s3 = s1 + s2;
        ----------------

            Console.WriteLine("Stopwatch application");
            Console.WriteLine("tap 'y' to start,'n' to stop,'q' to quit.");
            var stopWatch = new Stopwatch();
            while (true)
            {
                Console.WriteLine("tap 'y' to start,'n' to stop,'q' to quit.");
                var input = Console.ReadLine();

                if (input == "y")
                {
                    Console.WriteLine("start");
                    stopWatch.Start();
                }
                if (input == "n")
                 {
                    Console.WriteLine("stop");

                    stopWatch.Stop();
                    TimeSpan temp = stopWatch.Elapsed; //!!!!!!!!!!!!!!!!!рабочаяя
                    Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", temp.Hours, temp.Minutes, temp.Seconds);
                }
                if (input == "q") break;
            }

        --------------------
         var stopwatch = new Stopwatch();
            while (true)
            {
                Console.WriteLine("Tap 'y' to start, 'n' to stop, or 'q' to quit.");
                switch (Console.ReadLine())
                {
                    case "y":
                        Console.WriteLine("start");
                        // Resets *and* starts if necessary
                        stopwatch.Restart();
                        break;
                    case "n":
                        Console.WriteLine("stop");
                        stopwatch.Stop();
                        Console.WriteLine(stopwatch.Elapsed);
                        break;
                    case "q":
                        return;
                }
            }
         */
        #endregion

    }
}
