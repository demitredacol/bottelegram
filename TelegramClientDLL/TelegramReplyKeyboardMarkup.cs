using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramReplyKeyboardMarkup: TelegramReplyMarkup
    {
        public List<List<TelegramKeyboardButton>> keyboard;
        public Boolean resize_keyboard = false;
        public Boolean one_time_keyboard = false;
        public Boolean selective = false;
        
        public TelegramReplyKeyboardMarkup()
        {
            keyboard = new List<List<TelegramKeyboardButton>>();
        }
    }
}
