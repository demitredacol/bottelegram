using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace br.net.dacol.telegram
{
    public class TelegramResponse
    {
        public Boolean ok;
        public IList<TelegramUpdate> result;
    }
}
