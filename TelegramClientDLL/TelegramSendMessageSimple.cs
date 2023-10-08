using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramSendMessageSimple : TelegramSendMessage
    {
        public Int64 chat_id;
        public String text;
        public Boolean disable_notification = false;
    }
}
