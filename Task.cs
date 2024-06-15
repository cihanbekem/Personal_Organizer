using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class Task : Reminder
    {
        public string Description { get; set; }

        public override string GetDetails()
        {
            return $"Task: {Title} - {Description} by {Date} at {Hour} Summary: {Summary}";
        }
    }

}
