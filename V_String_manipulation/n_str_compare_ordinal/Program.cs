namespace n_str_compare_ordinal;
//Ordinal means comparing strings character by character using their Unicode (ASCII) values, without considering language or culture.
class Program
{
    static void Main(string[] args)
    {
        string s1 = "Rabi";
        string s2 = "Budhathoki";
        string s3 = "budhathoki";
        string s4 = "Rabi";

        Console.WriteLine(string.CompareOrdinal(s1, s2));
        Console.WriteLine(string.CompareOrdinal(s2, s3));
        Console.WriteLine(string.CompareOrdinal(s1, s4));
        Console.WriteLine(s1.CompareTo(s4));
    }
}
/*16
-32
0
0
*/