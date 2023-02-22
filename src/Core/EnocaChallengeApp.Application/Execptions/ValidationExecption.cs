using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Execptions
{
    public class ValidationExecption : Exception
    {
        public ValidationExecption() : base("Validation error occured")
        {

        }

        public ValidationExecption(string message) : base(message)
        {

        }

        public ValidationExecption(Exception ex) : this(ex.Message)
        {

        }
    }
}
