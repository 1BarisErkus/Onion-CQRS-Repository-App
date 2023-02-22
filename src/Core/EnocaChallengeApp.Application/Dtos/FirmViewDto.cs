using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Dtos
{
    public class FirmViewDto
    {
        public string FirmName { get; set; }
        public int ApprovelStatus { get; set; }
        public DateTime OrderClearanceStartTime { get; set; }
        public DateTime OrderClearanceFinishTime { get; set; }
    }
}
