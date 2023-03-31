class Result
{
    public static long repeatedString(string s, long n)
    {
        long numberOfAChars = 0;
        string infiniteString = s;
        long numberOfCharsChecked = 0;

        while (numberOfCharsChecked != n)
        {
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
