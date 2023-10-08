using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramInlineKeyboardButton
    {
        public String text;
        public String url;
        public String callback_data;

        public TelegramInlineKeyboardButton()
        {
        }

        public TelegramInlineKeyboardButton(String t, String u, String c)
        {
            text = t;
            url = u;
            callback_data = c;
        }
    }
}
