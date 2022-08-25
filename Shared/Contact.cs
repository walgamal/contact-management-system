using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpitecCMSApp.Shared
{
	public class Contact
	{
		public Guid Id { get; set; }
		[Required]
		public string lastName { get; set; } = string.Empty;
		[Required]
		public string firstName { get; set; } = string.Empty;
          public string phoneNum { get; set; } = string.Empty;
          public DateTime birthDate { get; set; }
	}
}
