using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result :IResult
    {
        //tek parametreli constructoruna success yollanır.her iki constructoruda çalıştırır.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {  
            Success = success;
        }

        bool Success { get; }
        string Message { get; }

        bool IResult.Success => throw new NotImplementedException();

        string IResult.Message => throw new NotImplementedException();
    }
}
