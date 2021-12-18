using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult :Result
    {
        //yapılan işlem true
        public SuccessResult(String message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
