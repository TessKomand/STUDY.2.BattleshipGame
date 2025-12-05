namespace ConsoleApp11 {
    internal class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int[,] mapa = new int[10, 10];
            int pozycjax;
            int pozycjay;
            int strzaly = 0;
            int wynik = 0;
            List<string> historia = new List<string>();
            Console.WriteLine("Witaj w grze w Statki, wpisz 1 by zacząć, 2 dla historii, 3 by zakończyć");
            int decyzja = int.TryParse(Console.ReadLine(), out int d) ? d : -1;

            do {
                if (decyzja == 1) {
                    for (int i = 0; i < 10; i++) {
                        pozycjax = rnd.Next(0, 10);
                        pozycjay = rnd.Next(0, 10);
                        if (mapa[pozycjax, pozycjay] == 0) {
                            mapa[pozycjax, pozycjay] = 1;
                        } else {
                            i--;
                        }
                    }
                    Console.WriteLine("Witaj w grze w statki, grasz na mapie 10 na 10, musisz zestrzelić 5 statków. Podaj swoje miejsce strzelania, masz 10 strzałów. podawaj miejsce jako x y");
                    do {
                        string[] misjece = Console.ReadLine().Split(' ');
                        int x = Convert.ToInt32(misjece[0]) - 1;
                        int y = Convert.ToInt32(misjece[1]) - 1;
                        if (x < 0 || x > 9 || y < 0 || y > 9) {
                            Console.WriteLine("Podano złe współrzędne, podaj jeszcze raz");
                            continue;
                        }
                        if (mapa[x, y] == 1) {
                            Console.WriteLine("Trafiony zatopiony!");
                            mapa[x, y] = 0;
                            wynik++;
                        } else {
                            Console.WriteLine("Pudło!");
                        }
                        strzaly++;
                        Sonar(mapa, x, y);
                    } while (strzaly <= 20);
                    Koniec(wynik);
                }
                if (decyzja == 2) {
                    Historia();
                }
            } while (decyzja != 4);

        }


        static int Sonar(int[,] mapa, int x, int y) {
            int[,] mapa2 = new int[12, 12];
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    mapa2[i + 1, j + 1] = mapa[i, j];
                }
            }
            x++;
            y++;
            if (mapa2[x + 1, y] == 1 || mapa2[x - 1, y] == 1 || mapa2[x, y + 1] == 1 || mapa2[x, y - 1] == 1) {
                Console.WriteLine("Statek jest blisko");
                return 1;
            } else {
                Console.WriteLine("Statek jest daleko");
                return 0;
            }
        }
        static int Koniec(int wynik,List<string> hisoria) {
            if (wynik == 10) {
                Console.WriteLine("Totalna wygrana");
                hisoria.Add("Totalna wygrana");
            } else if (wynik == 7) {
                Console.WriteLine("Wygrana");
            } else if (wynik == 4) {
                Console.WriteLine("Wygrana, z dużymi stratami");
            } else {
                Console.WriteLine("Przegrana");
            }
            Console.WriteLine("Wynik: " + wynik);
            return 0;
        }
        static string Historia() {
            return "";
        }
    }
}
