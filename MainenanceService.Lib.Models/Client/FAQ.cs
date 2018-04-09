using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintenanceService.Lib.Models
{
    public class FAQ
    {
        /// <summary>
        /// Gets or sets the question text.
        /// </summary>        
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the answer text.
        /// </summary>        
        public string Answer { get; set; }
    }
}