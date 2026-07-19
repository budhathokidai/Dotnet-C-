namespace b_enums_arrange;

class Program
{
     enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
     static void Main(string[] args)
     {
          var today = Days.Sunday;
          if (today == Days.Friday || today == Days.Saturday)
          {
               Console.WriteLine("Lets go for a round");
          }
          else
          {
               Console.WriteLine("This is work days ,go to work!");
          }

     }
}
