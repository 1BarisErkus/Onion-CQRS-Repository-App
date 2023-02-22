using EnocaChallengeApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int FirmId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

    }
}
