using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCuttingConcerns.Log4Net;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetailWithException : LogDetail
    {
        public string ExceptionMessage { get; set; }
    }
}
