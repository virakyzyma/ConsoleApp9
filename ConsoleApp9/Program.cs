namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            string str = "hello";
            for(int i=0; i<str.Length; i++)
            {
                int count = str.Length - str.Replace(str[i].ToString(), "").Length;
                Console.WriteLine($"Symbol {str[i]}- {count}");
                str = str.Replace(str[i].ToString(), "");
                i--;
            }
        }
    }
}
