using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace br.net.dacol.telegram
{
    public class TelegramMessage
    {
        public Int64 message_id;
        public TelegramUser from;
        public TelegramChat chat;
        public Int64 date;
        public String text;

        public TelegramMessage reply_to_message;
        public TelegramContact contact;
    }
}
