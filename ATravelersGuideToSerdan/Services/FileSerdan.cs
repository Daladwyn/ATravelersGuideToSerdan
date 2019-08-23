using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.ViewModels;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ATravelersGuideToSerdan.Services
{
    public class FileSerdan : IFileSerdan
    {
        public string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint )
        //public HttpResponseMessage CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint)
        {
            //FileStream wordFinalDocument;
            var filename = CharacterToPrint.CharacterName + ".docx";
            var path = Path.Combine(
                          Directory.GetCurrentDirectory(),
                          "wwwroot", filename);

            // Create Stream
            //using (MemoryStream mem = new MemoryStream())
            //{
            //    // Create Document
            //    using (WordprocessingDocument wordDocument =
            //        WordprocessingDocument.Create(mem, WordprocessingDocumentType.Document, true))
            //    {
            //        // Add a main document part. 
            //        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

            //        // Create the document structure and add some text.
            //        mainPart.Document = new Document();
            //        Body docBody = new Body();

            //        // Add your docx content here
            //    }




            //}
            //********************************************************************************************


            //********************************************************************************************

            using (var wordDocument = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Create text in body - CreateWordprocessingDocument"));


                // Create an empty table.
                Table table = new Table();

                // Create a TableProperties object and specify its border information.
                TableProperties tblProp = new TableProperties(
                    new TableBorders(
                        new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.Dashed), Size = 24 },
                        new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.Dashed), Size = 24 },
                        new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.Dashed), Size = 24 },
                        new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.Dashed), Size = 24 },
                        new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Dashed), Size = 24 },
                        new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Dashed), Size = 24 }
                    )
                );
                // Append the TableProperties object to the empty table.
                table.AppendChild<TableProperties>(tblProp);

                // Create a row.
                TableRow tr = new TableRow();

                // Create a cell.
                TableCell tc1 = new TableCell();

                // Specify the width property of the table cell.
                tc1.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));

                // Specify the table cell content.
                tc1.Append(new Paragraph(new Run(new Text(CharacterToPrint.PlayerName))));

                // Append the table cell to the table row.
                tr.Append(tc1);

                // Create a second table cell by copying the OuterXml value of the first table cell.
                //TableCell tc2 = new TableCell(tc1.OuterXml);
                TableCell tc2 = new TableCell();

                tc2.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));

                // Specify the table cell content.
                tc2.Append(new Paragraph(new Run(new Text(CharacterToPrint.CharacterName))));

                // Append the table cell to the table row.
                tr.Append(tc2);

                ////Create a new row in tablecell tc2
                //TableRow undertr1 = new TableRow();

                ////Create a new cell with the text "Namn:"
                //TableCell undertr1tc1 = new TableCell("Namn: " + CharacterToPrint.CharacterName);

                ////append the new cell to the row
                //undertr1.Append(undertr1tc1);

                ////create a new cell with the text "Spelare:"
                //TableCell undertr1tc2 = new TableCell("Spelare: " + CharacterToPrint.PlayerName);

                ////append the new cell to the row
                //undertr1.Append(undertr1tc2);

                ////create a second row within the cell
                //tc2.Append(undertr1);

                ////Create a new row in tablecell tc2
                //TableRow undertr2 = new TableRow();

                ////create a new cell with the text "Beskrivning:"
                //TableCell undertr2tc1 = new TableCell("Beskrivning:");

                ////Append the new cell to the second row in tc2
                //undertr2.Append(undertr2tc1);

                ////Append the second row to tc2
                //tc2.Append(undertr2);

                ////Create a new row in tablecell tc2
                //TableRow undertr3 = new TableRow();

                ////append the third row to tc2
                //tc2.Append(undertr3);

                // Append the table cell to the table row.
                //tr.Append(tc2);

                ////Create a third cell in the first row
                //TableCell tc3 = new TableCell();

                ////append tc3 to tr
                //tr.Append(tc3);

                ////create 3 rows with first row with text "fysisk skada"

                ////Create a fourth cell in the first row
                //TableCell tc4 = new TableCell();

                ////create 3 rows with first row with text "Själ skada"

                ////Append tc4 to tr
                //tr.Append(tc4);

                // Append the table row to the table.
                table.Append(tr);

                // Append the table to the document.
                wordDocument.MainDocumentPart.Document.Body.Append(table);

                // Save changes to the MainDocumentPart.
                wordDocument.MainDocumentPart.Document.Save();


                //byte[] byteArray = File.ReadAllBytes(wordDocument.ToString());
                //using (FileStream fileStream = new FileStream(path, FileMode.CreateNew))
                //{
                //    fileStream.Write(byteArray, 0, (int)byteArray.Length);

                //    // Save the file with the new name
                //    // wordDocument.WriteTo(fileStream);
                //    // Insert other code here. 
                //    //wordFinalDocument = fileStream;

                //    File.WriteAllText("", fileStream.ToString());
                //}



                //test

            }
            //return wordFinalDocument;
            //try
            //{
            //    File.WriteAllText("c:/SerdanCharacter.docx", wordFinalDocument);
            //    //File.WriteAllText(filepath, wordFinalDocument);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //WebClient webClient = new WebClient();
            //webClient.DownloadFile(path, filename);

            //return Download(filename);
            return filename;
            //return path;

            //public FileResult DownloadFile(string filename)
            //{
            //    var path = Path.Combine(
            //                      Directory.GetCurrentDirectory(),
            //                      "wwwroot", filename);
            //    var content = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            //    var response = File.(content, "application/octet-stream");//FileStreamResult
            //    return response;
            //}
            //public FileStream DownloadFile(string filename)
            //{
            //    var path = Path.Combine(
            //                   Directory.GetCurrentDirectory(),
            //                   "wwwroot", filename);
            //    return File.OpenRead(path); //, "application/octet-stream",
            //   // "NewName34.csv");
            //}
            //public async Task<FileStreamResult> Download(string filename)
            //{
            //    //if (filename == null)
            //    //    return Content("filename not present");

            //    var path = Path.Combine(
            //                   Directory.GetCurrentDirectory(),
            //                   "wwwroot", filename);

            //    //var memory = new MemoryStream();
            //    //using (var stream = new FileStream(path, FileMode.Open))
            //    //{
            //    //    await stream.CopyToAsync(memory);
            //    //}
            //    //memory.Position = 0;
            //    //var file = File.OpenRead(path);
            //    //return file; //(memory, GetContentType(path), Path.GetFileName(path));

            //    //return FileResult(path, "application/octet-stream", filename);
            //}
            //private string GetContentType(string path)
            //{
            //    var types = GetMimeTypes();
            //    var ext = Path.GetExtension(path).ToLowerInvariant();
            //    return types[ext];
            //}

            //private Dictionary<string, string> GetMimeTypes()
            //{
            //    return new Dictionary<string, string>
            //    {
            //        {".txt", "text/plain"},
            //        {".pdf", "application/pdf"},
            //        {".doc", "application/vnd.ms-word"},
            //        {".docx", "application/vnd.ms-word"},
            //        {".xls", "application/vnd.ms-excel"},
            //        {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
            //        {".png", "image/png"},
            //        {".jpg", "image/jpeg"},
            //        {".jpeg", "image/jpeg"},
            //        {".gif", "image/gif"},
            //        {".csv", "text/csv"}
            //    };
        }
        [HttpGet]
        public HttpResponseMessage Download(string fileName)
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK);

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", fileName);
            var fileBytes = File.ReadAllBytes(path);

            var fileMemStream = new MemoryStream(fileBytes);

            result.Content = new StreamContent(fileMemStream);

            var headers = result.Content.Headers;

            headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");

            headers.ContentDisposition.FileName = fileName;

            headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            headers.ContentLength = fileMemStream.Length;

            return result;
        }
    }
}
