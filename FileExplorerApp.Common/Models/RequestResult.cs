using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorerApp.Common.Models
{
    public enum RequestResultStatus
    {
        Error = 0,
        Success = 1,
        Duplicate = 2
    }

    public class RequestResult<T>
    {
        public RequestResultStatus Status { get; set; }
        public T Obj { get; set; }
        public string Message { get; set; }

        public RequestResult() { }

        public RequestResult(RequestResultStatus status, T obj)
        {
            Set(status, obj);
        }
        public RequestResult(RequestResultStatus status, T obj, string message)
        {
            Set(status, obj, message);
        }

        public void Set(RequestResultStatus status, T obj)
        {
            Status = status;
            Obj = obj;
        }
        public void Set(RequestResultStatus status, T obj, string message)
        {
            Status = status;
            Obj = obj;
            Message = message;
        }
    }
}
