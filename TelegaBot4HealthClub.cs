using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;


namespace TelegaBot4HealthClubFromCity
{

    public class TelegaBot4HealthClub
    {

        private static  string BotTokem = "6592601003:AAFBLd-o2bDUxhM_nMsWV74B3Rc_rl_-abc";

        private static TelegramBotClient BotClient = new TelegramBotClient(BotTokem);


        public static int RunBot()
        {

            return 0;
        }


        private static async void Bot_OnMessage(object sender, EventArgs e)
        {

        }


    }
}
