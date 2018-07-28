using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDi
{
    public interface IDocumentRepository
    {
        IDocument GetDocuments(int count);
    }
}