namespace feladatok10_16
{
    internal class Program
    {
        static Random r = new Random();
        static void feladat5()
        {
            int[] tomb = new int[5];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine($"Kérem a tömb {i+1}. számot");
                int szam = Convert.ToInt32(Console.ReadLine());
                tomb[i] = szam;
            }
            Console.WriteLine("A lista elemei sorba:");
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("A lista forditot elemei sorba:");
            for (int x = tomb.Length - 1; x >= 0; x--)
            {
                Console.WriteLine(tomb[x]);
            }
            Console.WriteLine("A lista minden második eleme:");
            for (int i = 1; i < tomb.Length; i+=2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine("kérek egy számot:");
            int keresetSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A megadot számon található tömb elem az {tomb[keresetSzam-1]}");
        }

        static void feladat14()
        {
            Console.WriteLine("Kérek egy számot:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[N];
            Console.WriteLine("Kérem az intervallum legkisebb számát:");
            int legkisebb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az intervallum legnagyobb számát:");
            int legnagyobb = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            feladat5();
        }
    }
}
