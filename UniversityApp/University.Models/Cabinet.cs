using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace University.Models
{
    public class Cabinet
    {
        public int Id { get; set; }
        public Dictionary<Group, DateTime> keyValuePairs;
    }
}