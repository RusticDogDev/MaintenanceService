using MaintenanceService.Lib.Models;

namespace MaintenanceService.Lib.ViewModels
{
    public class ContentViewModel
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