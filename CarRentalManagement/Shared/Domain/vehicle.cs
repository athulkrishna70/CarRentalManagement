using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
	public class vehicle : BaseDomainModel
	{
		public int year {  get; set; }
		public string LicensePlateNumber { get; set; }
		public int makeId { get; set; }
		public virtual Make? make{ get; set; }
		public int ModelId {  get; set; }
		public virtual model? model { get; set; }
		public int ColourId {  get; set; }
		public virtual colour? colour { get; set; }
		public virtual List<Booking>? Bookings { get; set; }
	}
}
