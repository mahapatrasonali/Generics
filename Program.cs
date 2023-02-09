namespace Generics
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string firststring = "Cat";
            string secondstring = "Apple";

          //  string value = firststring.CompareTo(secondstring);

            if(string.Equals(firststring,secondstring))
            {
                Console.WriteLine($"{firststring} is equal to {secondstring}");
            }
            else 
            {
                Console.WriteLine("strings Are Not same");
            }
            Console.Read();


            
        }
    }
}
