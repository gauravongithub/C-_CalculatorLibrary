using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace CSharpTutorials
{
    public class OperatorStructure
    {
        public string value { get; set; }
        public string display { get; set;}

        public int precedence {get; set;}
    }

    public class Operators
    {
        public List<OperatorStructure> operators { get; set; }
    }

    class TesterProgram
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("PrecedenceFileJSON.json");
            var precedenceFileJSON = JsonConvert.DeserializeObject<Dictionary<string, OperatorStructure>>(json);

            foreach (var precedenceFile in precedenceFileJSON)
            {
                Console.WriteLine("{0}  {1} {2} {3}",precedenceFile.Key, precedenceFile.Value.value, precedenceFile.Value.display,precedenceFile.Value.precedence);
            }
            Console.ReadLine();
            
        }
        
    }


}
