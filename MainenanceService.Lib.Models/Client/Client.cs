using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintenanceService.Lib.Models
{
    public class Client
    {
        /// <summary>
        /// Gets or sets the Client name.
        /// </summary>        
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Client name.
        /// </summary>        
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the Client Content.
        /// </summary>        
        public ClientContent Content { get; set; }
    }
}