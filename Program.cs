namespace Linq_lab{
    class program{
         static void Main(){
            string[] names = {"Bill","Steve","Mohan"};

            var myLinqQuery = from name in names where name .Contains("a") select name;

            foreach (string name in names)
            {
                System.Console.WriteLine(name+"");                
            }
        }
    }
}
