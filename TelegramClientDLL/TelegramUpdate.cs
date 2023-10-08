using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace br.net.dacol.telegram
{
    public class TelegramUpdate
    {
        public Int64 update_id;
        public TelegramMessage message;
        public TelegramCallbackQuery callback_query;
    }
}
