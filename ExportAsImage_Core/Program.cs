using Syncfusion.EJ2.PdfViewer;
using System;
using System.Drawing;

namespace ExportAsImage_Core
{
    class Program
    {
        static void Main(string[] args)
        {//Uses the Syncfusion.EJ2.PdfViewer assembly
            PdfRenderer pdfExportImage = new PdfRenderer();
            pdfExportImage.Load(@"currentDirectory\..\..\..\..\Data\pdfdocument.pdf");
            Bitmap[] bitmapimage = pdfExportImage.ExportAsImage(0, pdfExportImage.PageCount-1);
            for(int i =0; i<bitmapimage.Length;i++)
            {
                bitmapimage[i].Save(@"currentDirectory\..\..\..\..\Images\" + "bitmapImage" + i.ToString() + ".png");
               
            }
            Console.WriteLine("Hello World!");
        }
    }
}
