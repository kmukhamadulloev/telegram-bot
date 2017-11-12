using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBot
{
    public partial class Form1 : Form
    {
        private static TelegramBotClient bot;
        private bool botEnabled = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void addLog(string text)
        {
            Invoke((MethodInvoker)delegate
            {
                appLog.Items.Add($"[{DateTime.Now.ToShortTimeString()}]: {text}");
            });
        }

        private async void InitBot()
        {
            try
            {
                var me = await bot.GetMeAsync();
                inputBotName.Text = me.Username;
            }
            catch (Exception ex)
            {
                addLog(ex.Message);
                System.Threading.Thread.Sleep(500);
                InitBot();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AppUpgraded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.AppUpgraded = false;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.ApiToken.Length > 0)
            {
                bot = new TelegramBotClient(Properties.Settings.Default.ApiToken);
                botEnabled = true;

                bot.OnMessage += Bot_OnMessage;
                InitBot();
                bot.StartReceiving();
            }

            inputApiToken.Text = Properties.Settings.Default.ApiToken;
            inputUserId.Text = Properties.Settings.Default.ApiUser;
        }

        private async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var message = e.Message;
            addLog($"{message.Chat.Id.ToString()} :: {message.Text}");
            // MessageBox.Show($"{message.Chat.Id.ToString()} :: {message.Text}");

            var replyKeyboard = new ReplyKeyboardMarkup(new[] {
                new[]
                {
                    new Telegram.Bot.Types.KeyboardButton("Kill")
                },

                new[]
                {
                    new Telegram.Bot.Types.KeyboardButton("Downloads")
                }
            });

            if (message.Chat.Id.ToString() != Properties.Settings.Default.ApiUser)
            {
                await bot.SendTextMessageAsync(message.Chat.Id, @"Fuck you!");
                return;
            }

            if (message.Text.StartsWith("Kill") || message.Text.StartsWith("/kill"))
            {
                await bot.SendTextMessageAsync(
                    message.Chat.Id,
                    @"Kill yourself, faggot",
                    replyMarkup: replyKeyboard
                );
            }
            else if (message.Text.StartsWith("Downloads") || message.Text.StartsWith("/downloadlist"))
            {
                var filter = message.Text.Replace("Downloads", "").Replace("/downloadlist", "").Trim();
                filter = filter.Length > 0 ? $"*.{filter}" : null;

                var list = Commands.ListDownloads(@"C:\Users\diSQRL\Downloads\", filter);

                await bot.SendTextMessageAsync(
                    message.Chat.Id,
                    $"List of shit: ```\n{String.Join("\n", list.ToArray())}\n```",
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown,
                    replyMarkup: replyKeyboard
                );
            }
            else if (message.Text.StartsWith("/downloadfromurl"))
            {
                var filter = message.Text.Replace("/downloadfromurl", "").Trim();
                if (filter.Length > 0)
                {
                    bool result = Commands.DownloadFromURL(filter, @"C:\Users\diSQRL\Downloads\");
                    await bot.SendTextMessageAsync(
                        message.Chat.Id,
                        $"File was downloaded: {result}"
                    );
                }
                else
                {
                    await bot.SendTextMessageAsync(
                        message.Chat.Id,
                        "Command is incorrect!"
                    );
                }
            }
            else
            {
                await bot.SendTextMessageAsync(
                    message.Chat.Id,
                    @"You've sent me a message: ",
                    replyToMessageId: message.MessageId,
                    replyMarkup: replyKeyboard
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ApiToken = inputApiToken.Text;
            Properties.Settings.Default.ApiUser = inputUserId.Text;
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
