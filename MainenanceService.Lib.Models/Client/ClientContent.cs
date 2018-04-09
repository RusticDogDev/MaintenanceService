using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintenanceService.Lib.Models
{
    public class ClientContent
    {
        /// <summary>
        /// Gets or sets the Logo address.
        /// </summary>        
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>        
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the sub title.
        /// </summary>        
        public string SubTitle { get; set; }

        /// <summary>
        /// Gets or sets the bodytitle.
        /// </summary>        
        public string Bodytitle { get; set; }

        /// <summary>
        /// Gets or sets the bodytext.
        /// </summary>        
        public string Bodytext { get; set; }

        /// <summary>
        /// Gets or sets the bodytext.
        /// </summary>        
        public List<int> ContactPhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the contact email addresses.
        /// </summary>        
        public List<string> ContactEmailAddresses { get; set; }

        /// <summary>
        /// Gets or sets the frequently answered questionss.
        /// </summary>        
        public List<FAQ> FAQs { get; set; }
    }
}