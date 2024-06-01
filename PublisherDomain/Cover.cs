using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomain
{
    public class Cover
    {
        public int CoverID { get; set; }
        public string DesignIdeas { get; set; }
        public bool DigitalOnly { get; set; }
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
