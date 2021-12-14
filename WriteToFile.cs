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
        public void ExceptionMethod()
        {
            Console.WriteLine("Ткстовое  Исключение!");
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
                userException.ExceptionMethod();

                try
                {
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



            }
        }
    }
}
