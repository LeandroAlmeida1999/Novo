using ConsoleApp2.ConcretProducts;
using ConsoleApp2.Creator;
using ConsoleApp2.Product;
using System.Collections.Generic;

namespace ConsoleApp2.ConcretCreator
{
    public class ConcretDocumentFactory : DocumentFactory
    {
        private int _ano;
        private int _trimestre;

        public ConcretDocumentFactory(int ano, int trimestre)
        {
            this._ano = ano;
            this._trimestre = trimestre;
        }

        public override List<Document> GetDocument()
        {
            List<Document> documentList = new List<Document>();
            documentList.Add(new DocumentConcemis(_ano, _trimestre));
            documentList.Add(new DocumentContatos(_ano, _trimestre));
            documentList.Add(new DocumentDataBase(_ano, _trimestre));
            documentList.Add(new DocumentEmissor(_ano, _trimestre));
            documentList.Add(new DocumentLucremis(_ano, _trimestre));
            documentList.Add(new DocumentPortador(_ano, _trimestre));

            return documentList;
        }
    }
}