using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mailDownloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<OpenPop.Mime.Message> messages = new List<OpenPop.Mime.Message>();

                messages = EmailDownloader.FetchAllMessages("pop.yandex.ru", 995, true, "split4366", "split43664353646456456");

                foreach (var item in messages)
                {
                    Console.WriteLine(item.MessagePart.ContentType);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
    }
}
