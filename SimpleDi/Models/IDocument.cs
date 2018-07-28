using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDi
{
    public interface IDocument
    {
        int Id { get; set; }
        string FullName { get; }
        string Name { get; set; }
    }
}