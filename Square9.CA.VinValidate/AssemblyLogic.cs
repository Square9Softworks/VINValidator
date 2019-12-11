using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square9.CA.VinValidate
{
    public class AssemblyLogic
    {
        public Dictionary<string, string> RunCallAssembly(Dictionary<string, string> Input)
        {
            Dictionary<string, string> Output = new Dictionary<string, string>();
            String vinKey = "";
            String vinStatusKey = "";
            Boolean vinStatus = false;

            Console.WriteLine(DateTime.Now.ToString() + "\tSquare 9 Softworks VIN Validation.");

            foreach (String item in Input.Keys)
            {
                if (!vinStatus && !String.IsNullOrEmpty(Input[item]) && Input[item].ToUpper().StartsWith("VIN:"))
                {
                    Console.WriteLine(DateTime.Now.ToString() + "\tSquare 9 Softworks VIN Validation: VIN field found - " + Input[item]);
                    vinKey = item;
                    vinStatus = Validator.Vin.IsValid(Input[item].Substring(4));
                }

                if (vinStatusKey == "" && !String.IsNullOrEmpty(Input[item]) && Input[item].ToUpper().StartsWith("VINSTATUS:"))
                {
                    Console.WriteLine(DateTime.Now.ToString() + "\tSquare 9 Softworks VIN Validation: VIN status field found - " + item);
                    vinStatusKey = item;
                }
            }

            if(vinKey == "")
                Console.WriteLine(DateTime.Now.ToString() + "\tSquare 9 Softworks VIN Validation: No VIN field found.  Data must be prefaced with the literal value \"VIN:\"");

            if(vinStatusKey=="")
                Console.WriteLine(DateTime.Now.ToString() + "\tSquare 9 Softworks VIN Validation: No return status field found.  Field must have a value of \"VINSTATUS:\"");

            if (!String.IsNullOrEmpty(vinStatusKey))
                Output.Add(vinStatusKey, vinStatus.ToString());

            return Output;
        }
    }
}
