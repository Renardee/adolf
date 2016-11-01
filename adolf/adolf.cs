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
            RegisterCommands();

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
                
                .Do(async (e) =>                           
                {
                    string text = "Moje uczucia jako chrześcijanina wskazują mi mojego Pana i Zbawcę jako wojownika. Wskazują mi człowieka, który kiedyś w swej samotności, otoczony przez garstkę uczniów, rozpoznawał w Żydach, czym naprawdę są, i zebrał ludzi, by walczyć przeciwko nim, i który był największym nie jako męczennik, ale jako wojownik. W nieograniczonej miłości jako chrześcijanin i jako człowiek czytam ustępy, które mówią, jak Pan wystąpił w swej mocy i pochwycił bicz, by wypędzić ze świątyni ten ród węży i żmij. Jak wspaniała była jego walka w obronie świata przeciwko truciźnie żydowskiej. Dziś, po dwu tysiącach lat, z głębokim uczuciem rozpoznaję wyraźniej niż kiedykolwiek, że w tym właśnie celu rozlał On swoją krew na krzyżu. Jako chrześcijanin nie mam obowiązku, by przyzwalać na oszukiwanie mnie, lecz obowiązkiem moim jest być wojownikiem o prawdę i sprawiedliwość… I jeśli jest cokolwiek, co potwierdzałoby, że działamy właściwie, jest to ucisk, który codziennie wzrasta. Jako chrześcijanin mam też obowiązek wobec mojego własnego narodu. Kiedy wychodzę rano i widzę tych ludzi stojących w kolejkach i patrzę na ich ściśnięte twarze, wierzę, że byłbym nie chrześcijaninem, ale samym diabłem, gdybym nie odczuwał żalu, gdybym nie zwrócił się, jak nasz Pan dwa tysiące lat temu, przeciwko tym którzy do dziś wykorzystują i grabią tych biedaków.";
                    await e.Channel.SendMessage(text); 
                });

           
                
        }
        #endregion
    }
}

    

