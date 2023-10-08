using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramSendMessageKeyboard: TelegramSendMessage
    {
        public Int64 chat_id;
        public String text;
        public TelegramReplyMarkup reply_markup;
    }
}
