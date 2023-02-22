using EnocaChallengeApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int FirmId { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date_ { get; set; }
    }
}
