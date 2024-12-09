namespace Array_Strings_Hash 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myExc = new ArrayExercises();
            var result = myExc.MaxProfit([7, 6, 4, 3, 1]);
            Console.WriteLine(result);
        }
    }
}