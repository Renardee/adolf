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
            RegisterCommands();

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MjQyOTY5MTkyMTUwNzI4NzA0.Cvpr1w.q7CoIXie0r7PG3CHvyxHngnSuy0", TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
   
        private void RegisterCommands()
        {

            commands.CreateCommand("wyglosmowe") 
                .Description("Adolf przemawia") 
                .Alias("wm")                                                                                                    
                
                .Do(async (e) =>                           
                {

                    Random rnd = new Random();
                    int uku = rnd.Next(1, 37);
                    string text = "tekst";
                    switch (uku)
                    {
                        case 1:
                            text = "Moje uczucia jako chrześcijanina wskazują mi mojego Pana i Zbawcę jako wojownika. Wskazują mi człowieka, który kiedyś w swej samotności, otoczony przez garstkę uczniów, rozpoznawał w Żydach, czym naprawdę są, i zebrał ludzi, by walczyć przeciwko nim, i który był największym nie jako męczennik, ale jako wojownik. W nieograniczonej miłości jako chrześcijanin i jako człowiek czytam ustępy, które mówią, jak Pan wystąpił w swej mocy i pochwycił bicz, by wypędzić ze świątyni ten ród węży i żmij. Jak wspaniała była jego walka w obronie świata przeciwko truciźnie żydowskiej. Dziś, po dwu tysiącach lat, z głębokim uczuciem rozpoznaję wyraźniej niż kiedykolwiek, że w tym właśnie celu rozlał On swoją krew na krzyżu. Jako chrześcijanin nie mam obowiązku, by przyzwalać na oszukiwanie mnie, lecz obowiązkiem moim jest być wojownikiem o prawdę i sprawiedliwość… I jeśli jest cokolwiek, co potwierdzałoby, że działamy właściwie, jest to ucisk, który codziennie wzrasta. Jako chrześcijanin mam też obowiązek wobec mojego własnego narodu. Kiedy wychodzę rano i widzę tych ludzi stojących w kolejkach i patrzę na ich ściśnięte twarze, wierzę, że byłbym nie chrześcijaninem, ale samym diabłem, gdybym nie odczuwał żalu, gdybym nie zwrócił się, jak nasz Pan dwa tysiące lat temu, przeciwko tym którzy do dziś wykorzystują i grabią tych biedaków.";
                            break;
                        case 2:
                            text = "Polska zdecydowała się walczyć i jej życzenie zostało spełnione. Walkę wybrała niefrasobliwie, gdyż niektórzy mężowie stanu zapewniali ją, że dysponują szczegółową wiedzą o braku wartości Niemiec i ich sił zbrojnych, o niższości naszego uzbrojenia, o słabym morale naszych wojsk, o defetyzmie panującym w Rzeszy, o rozdźwięku między narodem niemieckim, a jego przywódcami. (…) W chwili gdy do was przemawiam, nasze wojska tworzą potężną linię od Brześcia Litewskiego po Lwów; od wczorajszego popołudnia niekończące się kolumny żołnierzy z rozbitej polskiej armii wymaszerowują z tego sektora jako jeńcy. (…) To, co pozostało z armii polskiej na zachód od tej linii, skapituluje w ciągu kilku dni; złożą broń albo zostaną zmiażdżeni.";
                            break;
                        case 3:
                            text = "W obecnej godzinie czuję się zobowiązany wobec swojego sumienia do jeszcze jednego apelu do rozsądku Anglii. Uważam, że mogę to uczynić, ponieważ nie proszę o coś jako pokonany, lecz opowiadam się jako zwycięzca za rozsądkiem. Nie widzę powodu, który zmuszałby do kontynuowania tej walki. Żałuję ofiar, które będzie ona kosztować. Także mojemu własnemu narodowi chciałbym ich oszczędzić.";
                            break;
                        case 4:
                            text = "Zawarcie przez Watykan traktatu z nowymi Niemcami oznacza uznanie przez Kościół katolicki państwa narodowosocjalistycznego. Traktat ten jasno i wyraźnie pokazuje całemu światu, że twierdzenie o wrogości narodowego socjalizmu do religii jest kłamstwem. (…) Konkordat dał Niemcom możliwość i stworzył sferę zaufania, która będzie miała szczególne znaczenie w pilnej walce z międzynarodowym żydostwem.";
                            break;
                        case 5:
                            text = "Socjalizm! To jest w ogóle niefortunne słowo… Co socjalizm naprawdę oznacza? Jeśli ludzie mają coś do jedzenia i jakieś przyjemności, to wtedy mają socjalizm.";
                            break;
                        case 6:
                            text = "Rozkazałem niemieckim siłom powietrznym prowadzić działania w sposób humanitarny, atakując jedynie wojska uczestniczące w walkach. Polski rząd i dowództwo armii nakazały ludności cywilnej toczenie nieregularnej wojny z zasadzki. W tych okolicznościach bardzo trudno jest się powstrzymać. (…) Moja cierpliwość też może mieć granice.";
                            break;
                        case 7:
                            text = "Kościół katolicki przez piętnaście stuleci traktował Żydów jak szkodników, zamykał ich w gettach i tak dalej, ponieważ zorientowano się czym są Żydzi. Ja odwołuję się do tych piętnastu stuleci.";
                            break;
                        case 8:
                            text = "Jesteśmy socjalistami, jesteśmy wrogami obecnego systemu kapitalistycznego, który wykorzystuje ekonomicznie słabszych, z jego niesprawiedliwymi płacami, z niesprawiedliwą oceną osoby ludzkiej według jej zamożności a nie według odpowiedzialności i rzeczywistych dokonań. Jesteśmy zdeterminowani aby zniszczyć ten system za wszelką cenę";
                            break;
                        case 9:
                            text = "Dla przyszłości Niemiec trzy idee mają znaczenie kluczowe. [trzecią z nich jest]… Antysemityzm: uzasadnia on odrzucenie na tle rasowym tego, co jest z gruntu wrogie wszystkiemu, co niemieckie. Nacjonalizm jest w głównej mierze szczepionką przeciw zarazie, która ogarnęła świat, a antysemityzm niezbędnym środkiem ochronnym, można by powiedzieć przeciwciałem.";
                            break;
                        case 10:
                            text = "Bądźcie bez litości, bądźcie brutalni… Dżyngis-Chan rzucił na śmierć miliony kobiet i dzieci świadomie i z lekkim sercem – historia widzi w nim tylko wielkiego założyciela państw. Obecnie tylko na wschodzie umieściłem oddziały SS Totenkopf, dając im rozkaz nieugiętego i bezlitosnego zabijania kobiet i dzieci polskiego pochodzenia i polskiej mowy, bo tylko tą drogą zdobyć możemy potrzebną nam przestrzeń życiową.";
                            break;
                        case 11:
                            text = "Rucham ci matkę";
                            break;
                        case 12:
                            text = "Co na przykład możemy powiedzieć o plakacie reklamującym nowe mydło, jeżeli przedstawia inne mydła jako dobre?";
                            break;
                        case 13:
                            text = "Wenn die Kraft zum Kämpfe um die eigene Gesundheit nicht mehr vorhanden ist, endet das Recht zum Leben in dieser Welt des Kampfes. Sie Gehört nur dem kraftvollen „Ganzen” und nicht dem schwachen „Halben”";
                            break;
                        case 14:
                            text = "Jakże nędzne są myśli ludzi małych.";
                            break;
                        case 15:
                            text = "Zwycięzcy nikt nie będzie się pytał, czy mówił prawdę.";
                            break;
                        case 16:
                            text = "Zniszczenie Polski jest naszym pierwszym zadaniem.";
                            break;
                        case 17:
                            text = "Wystarczy tylko pchnąć drzwi i cała przegniła budowla zawali się z trzaskiem.";
                            break;
                        case 18:
                            text = "Wolałbym dać sobie wyrwać trzy lub cztery zdrowe zęby, niż przejść przez tę rozmowę raz jeszcze.";
                            break;
                        case 19:
                            text = "Wojna jest przegrana.";
                            break;
                        case 20:
                            text = "Walka z wewnętrznym wrogiem narodu nigdy nie rozbije się o formalną biurokrację lub jej nieudolność, lecz jedynie tam, gdzie formalna biurokracja państwowa miałaby się okazać niezdatną do rozwiązania jakiegoś problemu, naród niemiecki użyje swej aktywniejszej organizacji, by dopomóc sobie w zrealizowaniu konieczności życiowej (…), o czym może rozstrzygać państwo, o tym też ono rozstrzygnie. To, czego państwo nie będzie w stanie rozwiązać, zostanie rozwiązane za pomocą zorganizowanego ruchu (partyjnego).";
                            break;
                        case 21:
                            text = "W obecnej godzinie czuję się zobowiązany wobec swojego sumienia do jeszcze jednego apelu do rozsądku Anglii. Uważam, że mogę to uczynić, ponieważ nie proszę o coś jako pokonany, lecz opowiadam się jako zwycięzca za rozsądkiem. Nie widzę powodu, który zmuszałby do kontynuowania tej walki. Żałuję ofiar, które będzie ona kosztować. Także mojemu własnemu narodowi chciałbym ich oszczędzić.";
                            break;
                        case 22:
                            text = "Sudety są moim ostatnim żądaniem terytorialnym w Europie.";
                            break;
                        case 23:
                            text = "Ręka mi drży, ale serce nie.";
                            break;
                        case 24:
                            text = "Po fakcie człowiek żałuje tylko, że był za dobry.";
                            break;
                        case 25:
                            text = "Pakt jest tak długo ważny, jak długo służy celowi.";
                            break;
                        case 26:
                            text = "Najgłupszym możliwym błędem z naszej strony byłoby pozwolenie niższym rasom na posiadanie broni. Historia dowodzi, że wszyscy zdobywcy, którzy pozwolili niższym rasom na posiadanie broni, szykowali tym sobie upadek.";
                            break;
                        case 27:
                            text = "Nasza siła bierze się z naszej szybkości i brutalności. Dżyngis Chan prowadził miliony kobiet i dzieci na rzeź z premedytacją i lekkim sercem. Jednak historia pokazuje go jako wielkiego twórcę państwa (…). A zatem (…) wydałem rozkaz zabicia bez litości wszystkich mężczyzn, kobiet i dzieci polskiej rasy i języka. Tylko w ten sposób zyskamy przestrzeń życiową, której tak nam trzeba. Kto dziś mówi o eksterminacji Ormian?";
                            break;
                        case 28:
                            text = "Kiedy zacznie się operacja „Barbarossa”, świat wstrzyma oddech z podziwu i nic nie powie.";
                            break;
                        case 29:
                            text = "Jeżeli naród planuje toczyć wojnę, nie morduje swoich oficerów.";
                            break;
                        case 30:
                            text = "Kościół katolicki przez piętnaście stuleci traktował Żydów jak szkodników, zamykał ich w gettach i tak dalej, ponieważ zorientowano się czym są Żydzi. Ja odwołuję się do tych piętnastu stuleci.";
                            break;
                        case 31:
                            text = "Jeżeli ta wojna jest przegrana, to nie jest moim zmartwieniem, że giną w niej ludzie. Nie uronię za nich jednej łzy, bo nie zasłużyli na nic lepszego.";
                            break;
                        case 32:
                            text = "Jeśli niemiecki naród nie potrafi zwyciężyć, to powinien zginąć.";
                            break;
                        case 33:
                            text = "Jestem głodny.";
                            break;
                        case 34:
                            text = "Mnie nie interesuje prawo, mnie interesuje sprawiedliwość.";
                            break;
                        case 35:
                            text = "Ten widok był dla mnie urzeczywistnieniem rasowej profanacji.";
                            break;
                        case 36:
                            text = "Sumienie to żydowski wynalazek.";
                            break;
                        case 37:
                            text = "Wystarczy tylko pchnąć drzwi i cała przegniła budowla zawali się z trzaskiem.";
                            break;
                        case 38:
                            text = "Cztery kobiety pozostaną na zawsze w mojej pamięci: pani Troost, panią Wagner, panią Scholtz-Klink i Leni Riefenstahl.";
                            break;
                        case 39:
                            text = "Dla utrzymania porządku społecznego ważne jest posiadanie nie tylko głowy, lecz i pięści, inaczej pewnego dnia pojawi się siła bez umysłu i głowę rozbije.";
                            break;
                        case 40:
                            text = "Jak myśliwi dokarmiają zwierzynę, żeby ją przy okazji zabić, tak prawnicy hodują świat przestępczy.";
                            break;
                        case 41:
                            text = "Ma to posmak tragedii, że pancernik, ekstrakt ludzkiej sprawności w opanowaniu materii, w obliczu rozwoju lotnictwa stał się bezużytecznym gratem.";
                            break;
                        case 42:
                            text = "Ministerstwo spraw wewnętrznych wydało testy służące do sprawdzania, czy ktoś kwalifikuje się do sterylizacji. Gdyby moją matkę zapytano, dlaczego pływa statek zrobiony z żelaza, to bym się pewnie nigdy nie urodził! Na co najmniej trzy czwarte pytań z tego testu mama by nie odpowiedziała! Mogę tylko powiedzieć: do śmieci z tym!";
                            break;
                        case 43:
                            text = "Najpiękniejszym dniem mego życia będzie dzień, w którym wycofam się z życia politycznego i pozostawię za sobą wszystkie troski, plagi i kłopoty.";
                            break;
                        case 44:
                            text = "W porównaniu z Rosją Polska to całkiem kulturalny kraj.";
                            break;
                        case 45:
                            text = "Najcięższym ciosem, jaki kiedykolwiek spadł na ludzkość było nadejście chrześcijaństwa. Bolszewizm jest nieślubnym dzieckiem chrześcijaństwa. Jedno i drugie zostało wymyślone przez Żydów.";
                            break;
                        case 46:
                            text = "Jezus nie był Żydem.";
                            break;
                        case 47:
                            text = "Zerwę z Kościołem. Będzie miał wtedy za swoje.";
                            break;
                        case 48:
                            text = "Jeśli jeden z moich kierowców przejedzie dziecko i będzie powoływał się na to, że trąbił, powiem: co pan! Dziecko nie myśli, pan ma myśleć!";
                            break;
                        case 49:
                            text = "Chciałem dobrze…";
                            break;
                        case 50:
                            text = "Frytki z Colą.";
                            break;
                        case 51:
                            text = "Taka Szwajcaria to jest nic innego jak wrzód na ciele Europy, tego nie można tolerować!";
                            break;
                        case 52:
                            text = "Po zakończeniu semestru zawsze urządzaliśmy wielki jubel. Było bardzo wesoło, hulanka i swawola. I tam zdarzyło się, że się pierwszy i ostatni raz upiłem się. Dostaliśmy świadectwa, trzeba było to oblać. Jak się kończyło, Crux zawsze była ciut niespokojna. Po kryjomu poszliśmy do chłopskiej gospody, śpiewaliśmy pieśni zbójeckie i pili. Szczegółów nie pamiętam, potem to sobie odtworzyłem. Następnego dnia obudziła mnie mleczarka, która mnie znalazła na drodze ze Steyr na Karsten. Byłem w opłakanym stanie. Przychodzę do mojej Crux. Na litość Boską, panie Adolfie, jak pan wygląda! Kąpię się, ona mi robi czarną kawę, potem pyta: a jak tam świadectwo? Zaglądam do torby – nie ma! Chryste Panie! I co ja teraz pokażę matce? Mówię sobie, powiem, że pokazywałem w pociągu, przeciąg zdmuchnął za okno i przepadło! A Crux naciska. Co jest? – Ktoś mi rąbnął! – Mówi się trudno, musi pan zaraz pójść do szkoły, może dadzą duplikat. Ma pan jeszcze w ogóle pieniądze? – Ani grosza… Dała mi pięć guldenów. Idę do szkoły, dyrektor każe mi poczekać. W międzyczasie, okazało się, do szkoły dotarły cztery kawałki tego świadectwa. Po pijanemu, w nieświadomości pomyliłem je z papierem toaletowym. To był koszmar. Co usłyszałem od rektora, nie nadaje się do powtórzenia. Okropność. Przysiągłem na wszystkie świętości na resztę życia rzucić alkohol. Dostałem ten duplikat. Jak ja się krępowałem! Przyszedłem do Crux, a ona: i co powiedział? – Co powiedział, tego kobiecie nie powiem. Ale jedno pani mogę powiedzieć: koniec z alkoholem! To była lekcja, która nie pozwoliła mi nigdy więcej wypić. Pojechałem do domu z lekkim sercem, może nie takim całkiem lekkim, bo widywałem w życiu lepsze świadectwa.";
                            break;
                        case 53:
                            text = "Naszym zadaniem jest wychowanie człowieka, który będzie widział piękne i prawdziwie wspaniałe strony życia, który nie zamieni się przedwcześnie w ponurego zrzędę. Chcemy cieszyć się pełnią życia, trzymać się go i unikać wszystkiego, co według ludzkiej miary szkodzi bliźniemu. Jeśli teraz [23 IX 1941] szkodzę Rosjanom, to tylko dlatego, że inaczej oni szkodziliby mi. Tak robi i dobry Bóg: rzuca nagle masy ludzi na ziemię i niech się każdy sam martwi o siebie. Jeden zabiera drugiemu, i koniec końców pewne jest tylko to, że zwycięża silniejszy. To zresztą najsensowniejszy układ, gdyby było odwrotnie, nic by nie powstało. Gdybyśmy nie przestrzegali praw natury, nakazujących korzystanie z prawa silniejszego, to pewnego dnia pożarłyby nas dzikie zwierzęta, potem owady pożarłyby dzikie zwierzęta, aż w końcu pozostałyby tylko mikroby.";
                            break;
                        case 54:
                            text = "moja matka była na pewno prostą kobietą, co żyje dla swojego męża i dzieci, w towarzystwie naszych wykształconych pań czułaby się chyba nieswojo – ale dała narodowi niemieckiemu wielkiego syna!";
                            break;
                        case 55:
                            text = "Co do Polaków, mamy to szczęście, że są leniwi i głupi, zarozumiali.";
                            break;
                        case 56:
                            text = "Jest pan południowcem i nigdy nie zrozumie pan, jak bardzo mi, jako Niemcowi, potrzebne jest drewno z polskich lasów.";
                            break;
                        case 57:
                            text = "Mieszkańcy Europy stanowią na Świecie jedną, wspólną rodzinę. Dlatego wyobrażenie, że w tak ograniczonym „domu”, jakim jest Europa, utrzymanie różnego porządku prawnego i różnych wartości dla jednej wspólnoty mieszkańców, jest wyobrażeniem fałszywym.";
                            break;
                        case 58:
                            text = "Dobre kłamstwo jest jak magiczne zaklęcie.";
                            break;
                        case 59:
                            text = "Być obywatelem Rzeszy, nawet jeżeli jest się tylko zamiataczem ulic, musi być uważane za większy honor niż bycie królem w obcym kraju.";
                            break;
                        case 60:
                            text = "Jestem przekonany, że działam jako agent naszego Stwórcy. Walcząc z żydami, wykonuję pracę Pana Naszego.";
                            break;
                        case 61:
                            text = "Jak często widziałem oczy młodych ludzi błyszczące w odpowiedzi wtedy, kiedy wyjaśniałem im istotę ich misji i zapewniałem ich bez przerwy, że cała mądrość na tej ziemi jest niczym, o ile nie jest zastępowana i chroniona przez siłę, że łagodne bóstwa pokoju nie mogą poruszać siły, jeżeli nie towarzyszy im bóg wojny, i że każdy wielki akt pokoju musi być chroniony i wspomagany przez siłę.";
                            break;
                        case 62:
                            text = "Jeżeli podzielimy ludzki gatunek na trzy kategorie: twórców, obrońców i niszczycieli – Aryjska Rasa może być uważana za reprezentującą tę pierwszą kategorię.";
                            break;
                        case 63:
                            text = "Masy nie składają się z profesorów i dyplomatów. Człowiek, który pragnie pozyskać zwolenników, musi znać klucz, którym otworzy ich serca. To nie oznacza słabości, ale zdecydowanie i siłę";
                            break;
                        case 64:
                            text = "Nie ma nic bardziej przygnębiającego od obserwowania trzeźwym okiem zjawisk zachodzących w parlamencie i przypatrywania się stale powtarzającym się zdradom.";
                            break;
                        case 65:
                            text = "Obowiązkiem państwa jest pamiętać, że cokolwiek robi, musi być ukierunkowane na jeden cel i tylko jeden, nie można pozwolić na sprowadzenie jej na manowce przez tak zwaną „wolność prasy” albo nakłaniać ją do zaniedbywania swoich obowiązków i odmawiania strawy, której naród potrzebuje, aby być zdrowym. Państwo musi zdecydowanie kontrolować ten instrument edukacji narodu i umieścić go w służbie państwa i narodu.";
                            break;
                        case 66:
                            text = "Piękno mogą dostrzec jedynie stanowiący jego część.";
                            break;
                        case 67:
                            text = "Polityka wobec Polski miała także połowiczny wymiar. Drażniono tylko Polaków nigdy nie traktując ani ich, ani tej polityki poważnie. W efekcie nie było ani zwycięstwa dla Niemiec, ani pojednania z Polską, a wywołało to tylko wrogość Rosji.";
                            break;
                        case 68:
                            text = "Podczas gdy polityczny program partii jest zwykle receptą na osiągnięcie dobrych rezultatów w nadchodzących wyborach, to program światowej teorii jest równoznaczny z deklaracją wojny przeciw ogólnie przyjętemu poglądowi na życie.";
                            break;
                        case 69:
                            text = "Silny człowiek jest najmocniejszy, gdy jest sam.";
                            break;
                        case 70:
                            text = "Szerokie masy ludu łatwiej ulegają wielkiemu kłamstwu niż małemu.";
                            break;
                        case 71:
                            text = "Tak więc najpierw walka, a później pacyfizm.";
                            break;
                        case 72:
                            text = "Tak jak nasi przodkowie nie otrzymali w darze od niebios ziemi, na której dzisiaj żyjemy, lecz musieli ją wywalczyć z narażeniem życia, tak też w przyszłości łaska żadnych narodów nie nada nam ani ziemi, ani życia. Uczyni to jedynie moc miecza zwycięstwa.";
                            break;
                        case 73:
                            text = "Utrata czystości rasowej rujnuje szczęście narodu na zawsze";
                            break;
                        case 74:
                            text = "Tysiąc razy trudniej jest przełamać barierę instynktownej niechęci, sentymentalnej nienawiści i negatywnej słabości niż wyprostować opinie powstałe na skutek niewłaściwej czy błędnej wiedzy.";
                            break;
                        case 75:
                            text = "Wojna światowa była niezapomnianą chwilą mojej ziemskiej egzystencji.";
                            break;
                        case 76:
                            text = "Żyd, stosując przemoc, pozbywa się na tym polu wszystkich konkurentów. Przy pomocy wrodzonej brutalnej chciwości stawia związki zawodowe na poziomie brutalnej siły. Każdego, kto ma wystarczającą inteligencję do oparcia się żydowskim powabom, łamie się przez zastraszenie, jakkolwiek nie byłby zdecydowany i inteligentny. Te metody są niezwykle skuteczne. Za pośrednictwem związków zawodowych, które powinny ochraniać naród, Żyd niszczy teraz podstawy narodowej gospodarki.";
                            break;







                    }

                 
                    await e.Channel.SendMessage(text); //wysyla wiadomosc ze zmiennej text
                });

           
                
        }
     
    }
}

    

