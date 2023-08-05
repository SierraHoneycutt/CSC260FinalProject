using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MediaTracker
{
	public class TV : Media
	{
        public string director { get; set; }
        public string releaseDate { get; set; }
        public bool hasIsSequel { get; set; }
        public string type { get; set; }
        public List<string> cast { get; set; }

        public string addCast()
		{
			throw new NotImplementedException();
		}

		public string addType()
		{
			throw new NotImplementedException();
		}

		public bool addDirector()
		{
			throw new NotImplementedException();
		}

		public void addReleaseDate()
		{
			throw new NotImplementedException();
		}
	}
}
