class Result
{
    public static long repeatedString(string s, long n)
    {
        long numberOfAChars = 0;
        long numberOfCharsChecked = 0;
        char[] characters = s.ToCharArray();

        long simpleChecks = n / s.Length;
        long remainderCheck = n % s.Length;

        for (int i = 0; i < simpleChecks; i++)
        {
            numberOfAChars += s.Count(c => c == 'a');
        }

        for (int j = 0; j < remainderCheck; j++)
        {
            if (characters[j] == 'a')
            {
                numberOfAChars++;
            }
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
