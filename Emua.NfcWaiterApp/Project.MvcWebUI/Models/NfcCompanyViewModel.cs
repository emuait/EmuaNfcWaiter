using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MvcWebUI.Models
{
	public class NfcCompanyViewModel
	{
		public NfcCompany itemNfcCompany { get; set; }
		public List<NfcCompany> listNfcCompany { get; set; }

		public int Id { get; set; }
	}
}