using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCuttingConcerns.Logging;

namespace Core.CrossCuttingConcerns.Log4Net
{
    public class LogDetail
    {
        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }

    }
}
