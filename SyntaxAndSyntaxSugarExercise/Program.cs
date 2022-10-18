namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Original code
              int answer = 4;
string response;
if (answer < 9) 
{
    response = answer + " is less than nine";
}
else
{
    response = answer + " is greater than or equal to nine";
}*/
            //---------Inferred typing, string interpolation and ternary operator--------
            var answer = 4;
              var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);

        }
    }
}
