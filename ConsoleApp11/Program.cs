namespace ConsoleApp11 {
    internal class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int[,] mapa = new int[10, 10];
            int pozycjax;
            int pozycjay;
            int strzaly = 0;
            for (int i = 0; i < 5; i++) {
                pozycjax = rnd.Next(0, 10);
                pozycjay = rnd.Next(0, 10);
                if (mapa[pozycjax, pozycjay] == 0) {
                    mapa[pozycjax, pozycjay] = 1;
                } else {
                    i--;
                }
                Console.WriteLine("Witaj w grze w statki, grasz na mapie 10 na 10, musisz zestrzelić 5 statków. Podaj swoje miejsce strzelania, masz 10 strzałów. podawaj miejsce jako x y");
                do {
                    string[] misjece = Console.ReadLine().Split(' ');
                    int x = Convert.ToInt32(misjece[0])-1;
                    int y = Convert.ToInt32(misjece[1])-1;
                    if (x < 0 || x > 9 || y < 0 || y > 9) {
                        Console.WriteLine("Podano złe współrzędne, podaj jeszcze raz");
                        continue;
                    }
                    if (mapa[x, y] == 1) {
                        Console.WriteLine("Trafiony zatopiony!");
                        mapa[x, y] = 0;
                    } else {
                        Console.WriteLine("Pudło!");
                    }
                    strzaly++;
                } while (strzaly<=10);


            }
        }
    }
}
