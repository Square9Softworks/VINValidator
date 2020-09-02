using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square9.CA.VinValidate
{
    public class AssemblyLogic : Square9.CustomNode.CaptureNode
    {
        public override void Run()
        {
            var vinValue = Process.Properties.GetSingleValue(Settings.GetStringSetting("property"));
            var vinStatus = Validator.Vin.IsValid(vinValue);

            if (!vinStatus)
            {
                LogHistory("VIN Check Failed.  Ensure the VIN data is valid.");
                SetNextNodeByLinkName("Fail");
            }
            else
            {
                LogHistory("VIN passes with valid checksum.");
                SetNextNodeByLinkName("Pass");
            }
        }
    }
}
