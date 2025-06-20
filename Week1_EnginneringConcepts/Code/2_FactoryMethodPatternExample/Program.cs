using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            IDocument doc = wordFactory.CreateDocument();
            doc.Open();

            DocumentFactory pdfFactory = new PdfFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelFactory();
            IDocument excel = excelFactory.CreateDocument();
            excel.Open();
        }
    }
}

