namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {

            //Esercizio1();
            //Esercizio2();
            //Esercizio3();
            Esercizio4();

        }


        private static void Esercizio1()
        {
            int num = 100; //numeri da visualizzare 
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i * 2);
            }
        }

        private static void Esercizio2()
        {
            int num;
            do
            {
                Console.Write("Scrivi un numero: ");

                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);

            int fattoriale = 1;
            for (int i = num; i > 0; i--)
            {
                fattoriale *= i;
            }

            Console.WriteLine(fattoriale);
        }

        private static void Esercizio3()
        {
            Console.Write("Inserisci un numero in binario: ");
            string line = Console.ReadLine()??"1";

            double somma = 0;
            for(int i = 0;  i < line.Length; i++)
            {
                //togliendo a un char il valore char di -0 ritorna il numero vero
                int valore = Convert.ToInt32(line[i] - '0');

                somma += valore * Math.Pow(2, line.Length - i -1);


            }
            Console.WriteLine(somma);

        }

        private static void Esercizio4()
        {
            Console.Write("Scrivi un numero di cui vuoi la serie di fibonacci ");
            int num = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int second = 1;

            for(int i = 2; i <= num; i++)
            {
                int fibonacci = first + second;
                first = second;
                second = fibonacci;
            
            }

            Console.WriteLine(second);


        }
    }
}
