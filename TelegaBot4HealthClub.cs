using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;



namespace TelegaBot4HealthClubFromCity
{

    public class TelegaBot4HealthClub
    {

        private static  string botTokem = "6592601003:AAFBLd-o2bDUxhM_nMsWV74B3Rc_rl_-abc";

        private static ITelegramBotClient botClient = new TelegramBotClient(botTokem);


        public static int RunBot()
        {

            botClient.GetMeAsync();

            // botClient.OnMessage += Bot_OnMessage;
            // botClient.StartReceiving();

            return 0;
        }


        private static async void Bot_OnMessage(object sender, EventArgs e)
        {

        }


    }
}
