using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.IO;

namespace E_mailDownloader
{
    internal class SaverToDisc
    {
        public static Message SaveAndLoadFullMessage(Message message)
        {
            // FileInfo about the location to save/load message
            FileInfo file = new FileInfo("someFile.eml");

            // Save the full message to some file
            message.Save(file);

            // Now load the message again. This could be done at a later point
            Message loadedMessage = Message.Load(file);

            // use the message again
            return loadedMessage;
        }
    }
}
