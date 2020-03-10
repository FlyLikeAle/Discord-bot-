using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using Discord.Commands;
using System.Linq;
using System.Threading.Tasks;

namespace test_bott.Modules
{

    public class ping : ModuleBase<SocketCommandContext>
    {
        

        [Command("elf")]
        public async Task elf()
        {
            await ReplyAsync("meinsch nöd ölf");
        }

        [Command("Gay")]
        public async Task Hi()
        
            {
                string user = Context.Message.Author.Username;

                if (user == "anusfister42069")
                {
                    Random rnd = new Random();
                    int prz = rnd.Next(80, 100);
                    string gay = Convert.ToString(prz);
                    await ReplyAsync("Du bisch " + prz + "% Gayyyy");
                }
                else if (user == "TryFresco")
                {
                    await ReplyAsync("Du wirsch immer zu 100% gay si");
                }
                else
                {
                    Random rnd = new Random();
                    int prz = rnd.Next(1, 20);
                    string gay = Convert.ToString(prz);
                    await ReplyAsync("Du bisch " + prz + "% Gayyyy");
                }
            }

       
        

        [Command("Michele Basketball skills")]
        public async Task hss()
        {
            await ReplyAsync("There you go");
            await ReplyAsync("https://tenor.com/view/splash-basketball-shoot-ring-fail-gif-15987187");
        }

        [Command("Kobe")]
        public async Task hsfs()
        {
            await ReplyAsync("KKKKKKOOOOOOOOOBBBBBBBBEEEEEEEEEEEE");
            await ReplyAsync("https://tenor.com/view/kobe-bryant-kinblood-kobe-three-pointer-gif-12338806");
        }
        
        

        public class Kick : ModuleBase<SocketCommandContext>
        {
            [Command("kick"), Summary("Kicks a user from the guild.")]
            public async Task KickCommand(IGuildUser user, [Remainder] string reason = "no reason")
            {
                user.KickAsync(reason);
            }
        }

        [Command("commands")]
        public async Task hsfss()
        {
            await ReplyAsync("|elf\n|Gay\n|ww3\n|Michele Basketball skills ");
            await ReplyAsync("|Kobe\n|kick\n|RIP Kobe\n|Basketball game");
            await ReplyAsync("|League stats (ingamename)\n|Sasuke\n|Serie (serie/welche Staffel Abstand = - Bsp.Cat dog->Cat-dog/2 <- welche Staffel)");
            
        }

        [Command("RIP Kobe")]
        public async Task hsssfs()
        {
            await ReplyAsync("(⌣̩̩́_⌣̩̩̀)");
            await ReplyAsync("https://tenor.com/view/kobe-bryant-nba-basketball-rip-rest-in-peace-gif-16154354");
        }

        [Command("Basketball game")]
        public async Task hgs()
        {
            await ReplyAsync("Wähl eine vo de zwei chörb. Falls de richtig wählsch bechunsch en pris vo @FlyLikeAle. Schrieb |1 für de erst und |2 für de zweit.");
            await ReplyAsync(":basketball: :wastebasket:                                     :basketball: :wastebasket:");
        }

        [Command("1")]
        public async Task has()
        {
            int prz2 = 0;
            string user = Context.Message.Author.Username;

            if (user == "2" || user == "1")
            {
                Random rnd = new Random();
                prz2 = rnd.Next(1, 50);
                string gay2 = Convert.ToString(prz2);
            }

            if(prz2 >= 8 && prz2 <=24)
            {
                await ReplyAsync("Herzliche Glückwunsch du hesch gunne.");
            }
            else
            {
                await ReplyAsync("Leider hesch nöd gunne du chaschs ja nomol versueche.");
            }
        }

        [Command("2")]
        public async Task ha1s()
        {
            int prz3 = 0;
            string user = Context.Message.Author.Username;

            if (user == "2" || user == "1")
            {
                Random rnd = new Random();
                prz3 = rnd.Next(1, 50);
                string gay3 = Convert.ToString(prz3);
            }

            if (prz3 >= 8 && prz3 <= 24)
            {
                await ReplyAsync("Herzliche Glückwunsch du hesch gunne.");
            }
            else
            {
                await ReplyAsync("Leider hesch nöd gunne du chaschs ja nomol versueche.");
            }
        }

        [Command("League stats")]
        public async Task ffsfs(string username)
        {
            
            await ReplyAsync("https://euw.op.gg/summoner/userName=" + username + "");
        }

        [Command("Sasuke")]
        public async Task ffasfs()
        {

            await ReplyAsync("NNNNAAAAAAAAARRRRRRRRRRUUUUUUUUUTTTTTTTTOOOOOOO");
            await ReplyAsync("https://i.makeagif.com/media/2-25-2018/6FruYB.gif");
        }

        [Command("Serie")]
        public async Task ffsfsfs(string Serie)
        {

            await ReplyAsync("https://bs.to/serie/" + Serie + "");
        }
        
    }
}

