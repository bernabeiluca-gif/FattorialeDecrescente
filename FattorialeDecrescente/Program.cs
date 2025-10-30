namespace FattorialeDecrescente
{
    internal class Program
    {
        static int FattorialeDecrescente(int n)
        {
            int u = 1;
            for(int i=1;i<=n;i++)
            {
                u = u * 1;
            }
            return u;
        }
        static int somma(int n)
        {
            int somma = 0;
            for(int i=n;i>=1;i--)
            {
                somma=somma+FattorialeDecrescente(i);
            }
            return somma;
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Dimmi un numero");
            numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(somma(numero));
        }
    }
}
