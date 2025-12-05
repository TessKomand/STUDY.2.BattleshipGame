namespace ConsoleApp11 {
    internal class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int[,] mapa = new int[10, 10];
            int pozycjax;
            int pozycjay;
            for (int i = 0; i < 5; i++) {
                pozycjax = rnd.Next(0, 10);
                pozycjay = rnd.Next(0, 10);
                if (mapa[pozycjax, pozycjay] == 0) {
                    mapa[pozycjax, pozycjay] = 1;
                } else {
                    i--;
                }
                Console.WriteLine("Witaj w grze w statki, grasz na mapie 10 na 10, musisz zestrzelić 5 statków");



            }
        }
    }
}
