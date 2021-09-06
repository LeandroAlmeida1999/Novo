using ConsoleApp2.ConcretCreator;
using ConsoleApp2.Creator;
using ConsoleApp2.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory documentFactory = null;

            Console.Write("Digite o ano que gostaria de obter: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Digite o trimestre que gostaria de obter: ");
            int quarter = int.Parse(Console.ReadLine());

            documentFactory = new ConcretDocumentFactory(year, quarter);

            List<Document> document = documentFactory.GetDocument();
            Document newDocument = document[0];
            Document newDocumenttwo = document[1];
            Document newDocumenttre = document[2];
            Document newDocumentqua = document[3];
            Document newDocumentcinc = document[4];
            Document newDocumentseis = document[5];
            
            Console.WriteLine("\nOs detalhes do seu Documento estão abaixo: \n" );
            Console.WriteLine($"Tipo do Documento: {newDocument.DocumentName}\nHeader e Filler do Documento: {newDocument.Header}\n{newDocument.Filler}");

            Console.ReadKey();
        }
    }
}
