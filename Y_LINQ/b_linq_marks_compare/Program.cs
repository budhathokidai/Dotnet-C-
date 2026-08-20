namespace b_linq_marks_compare;

class Program
{
    static void Main(string[] args)
    {
        
        int[] marks1 = { 23, 45, 3, 34, 54, 2, 23, 45 };
        int[] marks2 = { 12, 34, 23, 32, 12, 21, 56 };

        var resultSet = from a in marks1
                        from b in marks2
                        where a < b
                        select new { a, b };

        foreach (var item in resultSet)
        {
            Console.WriteLine("{0} is less than {1}", item.a, item.b);
        }
    }
}

/*23 is less than 34
23 is less than 32
23 is less than 56
45 is less than 56
3 is less than 12
3 is less than 34
3 is less than 23
3 is less than 32
3 is less than 12
3 is less than 21
3 is less than 56
34 is less than 56
54 is less than 56
2 is less than 12
2 is less than 34
2 is less than 23
2 is less than 32
2 is less than 12
2 is less than 21
2 is less than 56
23 is less than 34
23 is less than 32
23 is less than 56
45 is less than 56*/