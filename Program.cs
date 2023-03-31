class Result
{
    public static long repeatedString(string s, long n)
    {
        long numberOfAChars = 0;
        long numberOfCharsChecked = 0;
        char[] characters = s.ToCharArray();

        while (numberOfCharsChecked != n)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (characters[i] == 'a')
                {
                    numberOfAChars++;
                }
                numberOfCharsChecked++;
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
