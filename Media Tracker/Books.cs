using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MediaTracker
{
	public class Books : Media
	{
		public string author { get; set; }
        public string pubDate { get; set; }
        public bool sequel { get; set; }
        public string type { get; set; }

        public void addAuthor()
		{
			throw new NotImplementedException();
		}

		public bool hasIsSequel()
		{
			throw new NotImplementedException();
		}

		public void addPubDate()
		{
			throw new NotImplementedException();
		}

		public void addType()
		{
			throw new NotImplementedException();
		}
	}
}
