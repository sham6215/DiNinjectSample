using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDi
{
    public class Chart : IDocument
    {
        public string FullName => $"{Name} (Chart)";
        public int Id { get; set; }
        public string Name { get; set; }
    }
}