using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace borkedLabs.CrestScribe.ESI
{
    public class ESIResponse<T>
    {
        public readonly HttpStatusCode StatusCode;
        public bool Ok { get; set; }
        public T Result { get; set; }

        public ESIResponse(HttpStatusCode status, T result)
        {
            StatusCode = status;
            Result = result;
        }

        public bool IsSuccessStatus
        {
            get { return ((int)StatusCode >= 200) && ((int)StatusCode <= 299); }
        }
    }
}
