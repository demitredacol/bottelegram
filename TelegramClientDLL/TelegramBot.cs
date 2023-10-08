using System;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace br.net.dacol.telegram
{
    public class TelegramBot
    {
        private String NomeDoBot = "<NomeDoSeuBot>";
        private String TokenAPI = "<SeuToken>";
        private String BaseUrl = "https://api.telegram.org/bot";
        private String UrlApi = null;
        private String ultimoRetornoHTTP = string.Empty;

        public string UltimoRetornoHTTP { get => ultimoRetornoHTTP; }

        public TelegramBot(String _NomeDoBot, String _TokenAPI)
        {
            this.NomeDoBot = _NomeDoBot;
            this.TokenAPI = _TokenAPI;

            UrlApi = BaseUrl + TokenAPI + "/";
        }


        public TelegramBot()
        {
            UrlApi = BaseUrl + TokenAPI + "/";
        }

        public TelegramResponse CarregaAtualizacoes(Int64 offset)
        {
            TelegramResponse response;

            try
            {
                String UrlMetodo = UrlApi + "getupdates";
                if (offset > 0)
                {
                    UrlMetodo += "?offset=" + offset.ToString();
                }

                WebClient client = new WebClient();

                byte[] dados = client.DownloadData(UrlMetodo);

                ultimoRetornoHTTP = System.Text.Encoding.UTF8.GetString(dados);

                response = JsonConvert.DeserializeObject<TelegramResponse>(ultimoRetornoHTTP);
            }
            catch ( Exception ex)
            {
                response = new TelegramResponse
                {
                    ok = false,
                    result = new List<TelegramUpdate>()
                };
            }

            return response;
        }
        
        public TelegramSentMessage EnviaMensagem(Int64 chatid, String texto)
        {
            TelegramSendMessageSimple sm = new TelegramSendMessageSimple();
            sm.chat_id = chatid;
            sm.text = texto;

            return this.EnviaMensagem(sm);
        }
        
        public TelegramSentMessage EnviaMensagem(TelegramSendMessage sm)
        {
            String UrlMetodo = UrlApi + "sendMessage";

            String sms = JsonConvert.SerializeObject(sm);
            //byte[] smd = Encoding.ASCII.GetBytes(sms);
            byte[] smd = Encoding.UTF8.GetBytes(sms);

            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            client.Headers.Add("Accept", "application/json");

            byte[] bretorno = client.UploadData(UrlMetodo, "POST", smd);
            String sretorno = System.Text.Encoding.UTF8.GetString(bretorno);

            TelegramSentMessage retorno = JsonConvert.DeserializeObject<TelegramSentMessage>(sretorno);
            return retorno;
        }
    }
}
