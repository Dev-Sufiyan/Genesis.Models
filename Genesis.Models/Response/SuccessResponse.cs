using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Models.Response
{
    public class SuccessResponse<T>
    {
        public string Status { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }

        public SuccessResponse(T data, int statusCode, string status = "Success")
        {
            Status = status;
            Data = data;
            StatusCode = statusCode;
        }
    }
}
