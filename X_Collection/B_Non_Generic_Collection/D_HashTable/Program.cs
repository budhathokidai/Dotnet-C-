namespace D_HashTable;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Hashtable hash=new Hashtable();
        hash.Add(1,"Ram");
        hash.Add(2,10);
        hash.Add(3,10.4);
        hash.Add(4,true);
        Console.WriteLine("Hashtable Elements are:");
        foreach (DictionaryEntry item in hash)
        {
            Console.WriteLine(item.Key +" "+item.Value);
        }   
    }
}
