using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDi
{
    public class Publication : IDocument
    {
        public string FullName => $"{Name} (Publication)";
        public int Id { get; set; }
        public string Name { get; set; }
    }
}