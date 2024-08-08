using System;
using System.ComponentModel.DataAnnotations;

namespace HCLSWebAPI.CustomDataAnnotations
{
    public class ZeroOrNegativeCheckAttribute:ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            bool flag = true;
            int Val = Convert.ToInt32(value);

            if (Val <=0)
            {
                flag = false;
            }
            return flag;
        }
    }
}
