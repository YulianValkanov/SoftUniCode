using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Data.Models.Enums;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class ImportCardsImport
    {
		[Required]
		[RegularExpression(@"^\d{4} \d{4} \d{4} \d{4}$")]
		public string Number { get; set; }


		[Required]
		[RegularExpression(@"^\d{3}$")]
		public string CVC { get; set; }


		[Required]		
		
		public string Type  { get; set; }
		//"Cards": [
		//	{
		//		"Number": "1111 1111 1111 1111",
		//		"CVC": "111",
		//		"Type": "Debit"
		//	}
		//]
	}
}
