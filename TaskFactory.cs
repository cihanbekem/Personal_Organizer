using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class TaskFactory : IReminderFactory
    {
        public Reminder CreateReminder()
        {
            return new Task();
        }
    }
}
