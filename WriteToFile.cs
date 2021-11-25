using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimerNote
{
    class UserException : Exception
    {
        public void Method2()
        {
            Console.WriteLine("Мое Исключение!--");
        }
    }

    class WriteToFile
    {




        public void Write(string writ)
        {
            try
            {
                throw new UserException();

            }
            catch (UserException userException)
            {
                Console.WriteLine("Обработка исключения.");
                userException.Method2();

                try
                {
                    // FileStream fs =
                    // File.Open(@"C:\Users\jon\file.txt", FileMode.Open);
                    // string ff = "C:'\'Users\jon\file.txt";
                    StreamWriter f = new StreamWriter("C:\\file.txt", true);
                    f.WriteLine(writ);
                    f.WriteLine("Строка2");
                    f.WriteLine("Строка3");
                    f.Close();

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                //File.Open(@"C:\Users\jon\file.txt", FileMode.Open);

            }
        }
    }
}
