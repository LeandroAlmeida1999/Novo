using ConsoleApp2.ConcretCreator;
using ConsoleApp2.Product;
using System;
using System.Collections.Generic;

namespace ConsoleApp2.Creator
{
    public abstract class DocumentFactory
    {
        public abstract List<Document> GetDocument();

    }
}
