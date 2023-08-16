using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;



namespace TelegaBot4HealthClubFromCity
{

    public class TelegaBot4HealthClub
    {

        private static  string botTokem = "6592601003:AAFBLd-o2bDUxhM_nMsWV74B3Rc_rl_-abc";

        private static ITelegramBotClient botTelegaClient = new TelegramBotClient(botTokem);


        public static int RunBot()
        {

            //botTelegaClient.GetMeAsync();

            Console.WriteLine("Запущен бот " + botTelegaClient.GetMeAsync().Result.FirstName);


            // botTelegaClient.OnMessage += Bot_OnMessage;
            // botTelegaClient.StartReceiving();

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };

            botTelegaClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            return 0;
        }


        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");
            }
        }


        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }




    }
}
