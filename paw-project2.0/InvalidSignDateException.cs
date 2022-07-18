using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_project2._0
{ 
	internal class InvalidSignDateException : Exception
	{
		public DateTime SignDate { get; set; }

		public InvalidSignDateException(DateTime signDate)
		{
			SignDate = signDate;
		}

		public override string Message
		{
			get
			{
				return "Singning date " + SignDate + " is invalid";
			}
		}
	}
}
