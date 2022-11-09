internal class Program
{
    static readonly List<string> list = new();

    private static void Main()
    {
        while (true)
        {
            list.Add(GenRandomStr(10000));
            Thread.Sleep(1);
        }
    }

    static readonly Random rnd = new();

    static string GenRandomStr(int length)
    {
        var chars = new List<char>();

        for (var i = 0; i < length; i++)
        {
            var a = (char)rnd.Next(65, 122);
            chars.Add(a);
        }

        return string.Concat(chars);
    }
}
