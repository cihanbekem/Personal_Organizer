using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reminder
{
    public abstract class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }

        public DateTime Hour {  get; set; }

  
        public abstract string GetDetails();
    }

}
