namespace a_value_types;
class Student
{
    static void Main(string[] args)
    {
        
        char section = 'B';  // Stores a single character

       
        int roll = 15;   // Stores whole numbers

        
        short attendance = 180;  // Stores smaller whole numbers

       
        long phoneNumber = 9841234567;   // Stores very large whole numbers

       
        uint fees = 25000;   // Stores unsigned whole numbers (cannot be negative)

       
        ushort books = 12;   // Stores smaller unsigned whole numbers

       
        ulong collegeCode = 123456789;   // Stores very large unsigned whole numbers

        
        float gpa = 3.8f;   // Stores decimal numbers (less precision than double)

       
        double percentage = 87.56;   // Stores decimal numbers with high precision

      
        decimal balance = 1500.75m;    // Stores money-related values with high accuracy

        // Displaying all values
        Console.WriteLine("Section: " + section);
        Console.WriteLine("Roll No: " + roll);
        Console.WriteLine("Attendance: " + attendance);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Fees: " + fees);
        Console.WriteLine("Books: " + books);
        Console.WriteLine("College Code: " + collegeCode);
        Console.WriteLine("GPA: " + gpa);
        Console.WriteLine("Percentage: " + percentage);
        Console.WriteLine("Balance: " + balance);
    }
}
/*Section: B
Roll No: 15
Attendance: 180
Phone Number: 9841234567
Fees: 25000
Books: 12
College Code: 123456789
GPA: 3.8
Percentage: 87.56
Balance: 1500.75*/