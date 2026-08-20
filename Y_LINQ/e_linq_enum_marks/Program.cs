namespace e_linq_enum_marks;

class Program
{
    static void Main(string[] args)
    {
       int[] marks = { 12, 32, 83, 94, 21, 84, 32, 122, 22, 93, 4 };

        IEnumerable<int> marksQuery =
            from m in marks
            where m >= 80
            select m;

        foreach (var m in marksQuery)
        {
            Console.WriteLine(m);
        }
    }
}

/*83
94
84
122
93*/