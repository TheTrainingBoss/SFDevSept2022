/* ------------------------------------------------------------------------------
<auto-generated>
    This file was generated by Sitefinity CLI v1.1.0.22
</auto-generated>
------------------------------------------------------------------------------ */

using System;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SFDev2022.Mvc.Models
{
	public enum Enumeration
	{
		Value1,
		Value2,
		Value3
	}
	public class LinoWidgetModel
	{
		public string Message { get; set; }
		public bool Flag { get; set; }
		public Enumeration Enum { get; set; }
		public int Number { get; set; }
		public DateTime MyDate { get; set; }
	}
}