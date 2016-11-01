using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adolf
{
    public class hitler
    {
        private static DiscordClient discord;
        CommandService commands;

        public hitler()
        {
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Debug;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;
                x.HelpMode = HelpMode.Public;
            });

            commands = discord.GetService<CommandService>();
            

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MjQyOTY5MTkyMTUwNzI4NzA0.Cvpr1w.q7CoIXie0r7PG3CHvyxHngnSuy0", TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        #region Text Commands
        private void RegisterCommands()
        {

            commands.CreateCommand("wyglosmowe") 
                .Description("Adolf przemawia") 
                .Alias("wm")                                                                                                    
                .Parameter("", ParameterType.Unparsed) 
                .Do(async (e) =>                           
                {
                    string text = e.Args[5]; 
                    await e.Channel.SendMessage(text); 
                });

           
                
        }
        #endregion
    }
}

    

