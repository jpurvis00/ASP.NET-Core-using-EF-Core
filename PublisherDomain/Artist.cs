using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomain
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Cover> Covers { get; set; } = new List<Cover>();
    }
}
