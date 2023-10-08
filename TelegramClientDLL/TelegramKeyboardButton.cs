using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.net.dacol.telegram
{
    public class TelegramKeyboardButton
    {
        public String text;
        public Boolean request_contact = false;
        public Boolean request_location = false;

        public TelegramKeyboardButton()
        {
        }

        public TelegramKeyboardButton(String _text, Boolean _request_contact = false, Boolean _request_location = false)
        {
            this.text = _text;
            this.request_contact = _request_contact;
            this.request_location = _request_location;
        }

    }
}
