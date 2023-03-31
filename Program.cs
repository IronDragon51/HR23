class Result
{
    public static long repeatedString(string s, long n)
    {
        long numberOfAChars = 0;
        //string infiniteString = new string(s, 10000000);
        //string infiniteString = "";

        //infiniteString = string.Concat(Enumerable.Repeat(s, (int)n));

        //numberOfAChars = s.Count(x => x == a);

        string infiniteString = s;
        long numberOfCharsChecked = 0;

        while (numberOfCharsChecked != n)
        {
            //if (infiniteString[i] == 'a')
            //{
            //    numberOfAChars++; 
            //}
            numberOfAChars += s.Count(c => c == 'a');

            numberOfCharsChecked += s.Length;
        }

        return numberOfAChars;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        Console.WriteLine(result);

    }
}
