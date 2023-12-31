﻿using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

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


            ;

            ;

            botTelegaClient.StartReceiving(
                HandleUpdateAsync1,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

            ; 
            ; 
            ;

            return 0;
        }




        public static async Task HandleUpdateAsync1(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            ;
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                Message message = update.Message;

                


                long chatId = message.Chat.Id;

                



                //botClient.GetChatAsync();

                string sFirstName = message.From.FirstName;

                if (message.Text.ToLower().Contains("bye-bye"))
                {
                    await botClient.SendTextMessageAsync(message.Chat, "До свидания " + sFirstName);
                    return;
                }
                else if (message.Text.ToLower() == "/start")
                {

                    await botClient.SendTextMessageAsync(message.Chat, "Что Вам угодно ...");

                    IKeyboardButton[] keyboardButtons = new InlineKeyboardButton[4];

                    
                    keyboardButtons[0] = new InlineKeyboardButton("Пункт 1");

                    keyboardButtons[1] = new InlineKeyboardButton("Пункт 2");

                    keyboardButtons[2] = new InlineKeyboardButton("Пункт 3");

                    keyboardButtons[3] = new InlineKeyboardButton("Пункт 4");



                    //InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(sFirstName, keyboardButtons);

                    InlineKeyboardMarkup inlineKeyboard = new InlineKeyboardMarkup(new InlineKeyboardButton("Пункт 0"));

                    //botClient.OnMakingApiRequest

                    //botClient.ReceiveAsync()
                    //botClient.SendChatActionAsync()

                }
                else if (message.Text.ToLower().Contains("привет") || message.Text.ToLower().Contains("hello"))
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Привет " + sFirstName);
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat, "нажмите \"/start\" для начала работы или \"/help\"  для помощи ");

                }
                //   отобразить меню выбора
            }
            else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
            {
                ;
            }
            else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.InlineQuery)
            {
                ;
            }
            else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.ChosenInlineResult)
            {
                ;
            }
            else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery)
            {
                ;
            }
            else if (update.Type == Telegram.Bot.Types.Enums.UpdateType.ChatJoinRequest) 
            {
                ;
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
