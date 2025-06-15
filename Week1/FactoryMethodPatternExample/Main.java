package FactoryMethodPatternExample;

public class Main {
    public static void main(String[] args) {
        DocumentFactory wordFactory=new WordFactory();
        Document doc=wordFactory.createDocument();
        doc.open();
         DocumentFactory pdfFactory=new PdfFactory();
          Document pdf=pdfFactory.createDocument();
        pdf.open();
          DocumentFactory excelFactory=new ExcelFactory();
           Document excel=excelFactory.createDocument();
        excel.open();
        
    }
}
