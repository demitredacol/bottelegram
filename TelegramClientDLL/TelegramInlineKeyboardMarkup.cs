using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramInlineKeyboardMarkup : TelegramReplyMarkup
    {
        public List<List<TelegramInlineKeyboardButton>> inline_keyboard = new List<List<TelegramInlineKeyboardButton>>();
    }
}
