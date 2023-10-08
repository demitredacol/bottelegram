using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramCallbackQuery
    {
        public Int64 id;
        public TelegramUser from;
        public TelegramMessage message;
        public Int64 chat_instance;
        public String data;
    }
}
