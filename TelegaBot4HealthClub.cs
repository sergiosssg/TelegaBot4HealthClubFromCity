using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;



namespace TelegaBot4HealthClubFromCity
{

    public class TelegaBot4HealthClub
    {



        private static string botTokem = "6351080829:AAE49va6tJlpB9LBXQxd95spp2wbzVpuqe8";

        /*"6592601003:AAFBLd-o2bDUxhM_nMsWV74B3Rc_rl_-abc";*/

        private bool _aiireadyHelloSaid;

        private static ITelegramBotClient botTelegaClient = new TelegramBotClient(botTokem);


        public static int RunBot()
        {

            //botTelegaClient.GetMeAsync();


            Console.WriteLine($"Запущен бот {botTelegaClient.GetMeAsync().Result.FirstName}");


            // botTelegaClient.OnMessage += Bot_OnMessage;
            // botTelegaClient.StartReceiving();

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };


            //botTelegaClient.SendTextMessageAsync()



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
            ;
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;

                var sFirstName = message.From.FirstName;

                if (message.Text.ToLower().Contains("bye-bye"))
                {
                    await botClient.SendTextMessageAsync(message.Chat, "До свидания " + sFirstName);
                    return;
                }
                else if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Что Вам угодно ...");
                }
                else if (message.Text.ToLower().Contains("привет"))
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Привет " + sFirstName);
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat, "нажмите \"/start\" для начала ");

                }
                //   отобразить меню выбора
            }
        }


        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            if (exception != null)
            {
                ;
            }
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }




    }
}
