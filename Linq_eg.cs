
namespace Linq_eg{
    class Linq_eg{
        static void Main(){
            List<string> StringList = new List<string>(){
                "C# Tutorials",
                "VB.NET tutorials",
                "Learn C++",
                "Mike tutorials"
            };

            var myLinqQuery = from course in StringList where course.Contains("tutorials") select course;
            var result = StringList.Where(s=>s.Contains("tutorials"));
            foreach (string course in myLinqQuery)
            {
                System.Console.WriteLine(course+"");                
            }
            foreach (string s in result)
            {
                System.Console.WriteLine(s+"");                
            }
        }
    }
}