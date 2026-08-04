namespace m_str_compare;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Rabi";
        string s2 = "Budhathoki";
        string s3 = "rabi";
        string s4 = "Rabi";

        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s2, s3));
        Console.WriteLine(string.Compare(s1, s4)); // 0 (both strings are equal)
    }
}
