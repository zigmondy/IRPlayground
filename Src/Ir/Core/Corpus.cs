namespace Ir.Core
{
    using System.Collections.Generic;

    public class Corpus
    {
        public IList<Document> Documents { get; } = new List<Document>();
    }

    public class Document
    {
        public IList<Term> Terms { get; } = new List<Term>();
    }

    public class Term
    {

    }
}