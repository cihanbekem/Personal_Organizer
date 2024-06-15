using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class Meeting : Reminder
    {
        public string Location { get; set; }

        public override string GetDetails()
        {
            return $"Meeting: {Title} at {Location} on {Date} at {Hour} Summary: {Summary}";
        }
    }
}
