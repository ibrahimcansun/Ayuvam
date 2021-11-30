﻿using Core.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool sucess)
        {
            Success = sucess;
        }
        public Result(bool success ,string message):this(success)
        {
            Message = message;
        }

        public string Message { get;}
        public bool Success { get;}
    }
}
