using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Models.Response
{
    public class ErrorResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

        public ErrorResponse(int statusCode, string message, string status = "Error")
        {
            Status = status;
            Message = message;
            StatusCode = statusCode;
        }
    }
}
