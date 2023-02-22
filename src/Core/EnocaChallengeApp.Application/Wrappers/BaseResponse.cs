using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Wrappers
{
    public class BaseResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}
