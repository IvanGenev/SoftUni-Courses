using System;
using System.IO;
using System.Text;

namespace WritingTextToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Кирилица";
            Stream fileStream = new FileStream("../../log.txt", FileMode.Create);

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}
