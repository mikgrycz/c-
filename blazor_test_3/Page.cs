using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace blazor01 {
	/// <summary>
	/// Clas that representing single page
	/// </summary>
	public class Page {
		public string Url { private get; set; }
		public string Name { private get; set; }
		public string Html {
			get {
				return "... '" + this.Url + "'..." + this.Name + "…"; //to ma zwracać link do strony w kontenerze
			}
			private set { }
		}
	}
}