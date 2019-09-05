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
        public string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint)
        //public HttpResponseMessage CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint)
        {
            //FileStream wordFinalDocument;
            var filename = CharacterToPrint.CharacterName + ".docx";
            var path = Path.Combine(
                          Directory.GetCurrentDirectory(),
                          "wwwroot", filename);

            using (var wordDocument = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();



                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                //Paragraph para = body.AppendChild(new Paragraph());
                //Run run = para.AppendChild(new Run());
                //run.AppendChild(new Text("Serdan"));

                // Create an empty table.
                Table table = new Table();

                // Create a TableProperties object and specify its border information.
                TableProperties tblProp = new TableProperties(
                    new TableBorders(
                        new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 },
                        new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 },
                        new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 },
                        new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 }
                    // new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 },
                    // new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 }
                    )
                );
                // Append the TableProperties object to the empty table.
                table.AppendChild<TableProperties>(tblProp);

                // Create a row.
                TableRow tr1 = new TableRow();

                // Create a cell.
                TableCell tr1tc1 = new TableCell();

                //TableCellProperties tc1TCP = new TableCellProperties(new TableCellBorders(
                //    new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.None), },
                //    new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.BasicThinLines), Size = 10 }
                //    )
                //    );

                //tc1.AppendChild<TableCellProperties>(tc1TCP);

                // Specify the width property of the table cell.
                tr1tc1.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));

                // Specify the table cell content.
                tr1tc1.Append(new Paragraph(new Run(new Text("Serdan"))));

                // Append the table cell to the table row.
                tr1.Append(tr1tc1);

                // Create a second table cell by copying the OuterXml value of the first table cell.
                //TableCell tc2 = new TableCell(tc1.OuterXml);
                TableCell tr1tc2 = new TableCell();

                tr1tc2.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));

                // Specify the table cell content.
                tr1tc2.Append(new Paragraph(new Run(new Text(CharacterToPrint.PlayerName))));

                // Append the table cell to the table row.
                tr1.Append(tr1tc2);

                TableCell tr1tc3 = new TableCell();

                tr1tc3.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));

                // Specify the table cell content.
                tr1tc3.Append(new Paragraph(new Run(new Text(CharacterToPrint.CharacterName))));

                // Append the table cell to the table row.
                tr1.Append(tr1tc3);
                ////Create a new row in tablecell tc2
                TableRow tr2 = new TableRow();

                ////Create a new cell with the text "Namn:"
                TableCell tr2tc1 = new TableCell();
                tr2tc1.Append(new Paragraph(new Run(new Text("Egenskap"))));
                TableCell tr2tc2 = new TableCell("Tot./Uts.");
                TableCell tr2tc3 = new TableCell("Förmåga");
                TableCell tr2tc4 = new TableCell("Värde:");
                TableCell tr2tc5 = new TableCell("TP");
                TableCell tr2tc6 = new TableCell("Exp");
                TableCell tr2tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr2tc8 = new TableCell("TTP");
                TableCell tr2tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr2.Append(tr2tc1);
                tr2.Append(tr2tc2);
                tr2.Append(tr2tc3);
                tr2.Append(tr2tc4);
                tr2.Append(tr2tc5);
                tr2.Append(tr2tc6);
                tr2.Append(tr2tc7);
                tr2.Append(tr2tc8);
                tr2.Append(tr2tc9);
                table.Append(tr2);

                TableRow tr3 = new TableRow();
                TableCell tr3tc1 = new TableCell("Egenskap");
                TableCell tr3tc2 = new TableCell("Tot./Uts.");
                TableCell tr3tc3 = new TableCell("Vapen");
                TableCell tr3tc4 = new TableCell(new Paragraph(new Run(new Int32Value(CharacterToPrint.WeaponValue))));
                TableCell tr3tc5 = new TableCell("TP");
                TableCell tr3tc6 = new TableCell("Exp");
                TableCell tr3tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr3tc8 = new TableCell("TTP");
                TableCell tr3tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr3.Append(tr3tc1);
                tr3.Append(tr3tc2);
                tr3.Append(tr3tc3);
                tr3.Append(tr3tc4);
                tr3.Append(tr3tc5);
                tr3.Append(tr3tc6);
                tr3.Append(tr3tc7);
                tr3.Append(tr3tc8);
                tr3.Append(tr3tc9);
                table.Append(tr3);

                TableRow tr4 = new TableRow();
                TableCell tr4tc1 = new TableCell("Egenskap");
                TableCell tr4tc2 = new TableCell("Tot./Uts.");
                TableCell tr4tc3 = new TableCell("Skjutvapen");
                TableCell tr4tc4 = new TableCell(new Paragraph(new Run(new Int32Value(CharacterToPrint.BalisticValue))));
                TableCell tr4tc5 = new TableCell("TP");
                TableCell tr4tc6 = new TableCell("Exp");
                TableCell tr4tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr4tc8 = new TableCell("TTP");
                TableCell tr4tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr4.Append(tr4tc1);
                tr4.Append(tr4tc2);
                tr4.Append(tr4tc3);
                tr4.Append(tr4tc4);
                tr4.Append(tr4tc5);
                tr4.Append(tr4tc6);
                tr4.Append(tr4tc7);
                tr4.Append(tr4tc8);
                tr4.Append(tr4tc9);
                table.Append(tr4);

                TableRow tr5 = new TableRow();
                TableCell tr5tc1 = new TableCell("Egenskap");
                TableCell tr5tc2 = new TableCell("Tot./Uts.");
                TableCell tr5tc3 = new TableCell("Förmåga");
                TableCell tr5tc4 = new TableCell("Värde:");
                TableCell tr5tc5 = new TableCell("TP");
                TableCell tr5tc6 = new TableCell("Exp");
                TableCell tr5tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr5tc8 = new TableCell("TTP");
                TableCell tr5tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr5.Append(tr5tc1);
                tr5.Append(tr5tc2);
                tr5.Append(tr5tc3);
                tr5.Append(tr5tc4);
                tr5.Append(tr5tc5);
                tr5.Append(tr5tc6);
                tr5.Append(tr5tc7);
                tr5.Append(tr5tc8);
                tr5.Append(tr5tc9);
                table.Append(tr5);

                TableRow tr6 = new TableRow();
                TableCell tr6tc1 = new TableCell("Egenskap");
                TableCell tr6tc2 = new TableCell("Tot./Uts.");
                TableCell tr6tc3 = new TableCell("Förmåga");
                TableCell tr6tc4 = new TableCell("Värde:");
                TableCell tr6tc5 = new TableCell("TP");
                TableCell tr6tc6 = new TableCell("Exp");
                TableCell tr6tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr6tc8 = new TableCell("TTP");
                TableCell tr6tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr6.Append(tr6tc1);
                tr6.Append(tr6tc2);
                tr6.Append(tr6tc3);
                tr6.Append(tr6tc4);
                tr6.Append(tr6tc5);
                tr6.Append(tr6tc6);
                tr6.Append(tr6tc7);
                tr6.Append(tr6tc8);
                tr6.Append(tr6tc9);
                table.Append(tr6);

                TableRow tr7 = new TableRow();
                TableCell tr7tc1 = new TableCell("Egenskap");
                TableCell tr7tc2 = new TableCell("Tot./Uts.");
                TableCell tr7tc3 = new TableCell("Förmåga");
                TableCell tr7tc4 = new TableCell("Värde:");
                TableCell tr7tc5 = new TableCell("TP");
                TableCell tr7tc6 = new TableCell("Exp");
                TableCell tr7tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr7tc8 = new TableCell("TTP");
                TableCell tr7tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr7.Append(tr7tc1);
                tr7.Append(tr7tc2);
                tr7.Append(tr7tc3);
                tr7.Append(tr7tc4);
                tr7.Append(tr7tc5);
                tr7.Append(tr7tc6);
                tr7.Append(tr7tc7);
                tr7.Append(tr7tc8);
                tr7.Append(tr7tc9);
                table.Append(tr7);

                TableRow tr8 = new TableRow();
                TableCell tr8tc1 = new TableCell("Egenskap");
                TableCell tr8tc2 = new TableCell("Tot./Uts.");
                TableCell tr8tc3 = new TableCell("Förmåga");
                TableCell tr8tc4 = new TableCell("Värde:");
                TableCell tr8tc5 = new TableCell("TP");
                TableCell tr8tc6 = new TableCell("Exp");
                TableCell tr8tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr8tc8 = new TableCell("TTP");
                TableCell tr8tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr8.Append(tr8tc1);
                tr8.Append(tr8tc2);
                tr8.Append(tr8tc3);
                tr8.Append(tr8tc4);
                tr8.Append(tr8tc5);
                tr8.Append(tr8tc6);
                tr8.Append(tr8tc7);
                tr8.Append(tr8tc8);
                tr8.Append(tr8tc9);
                table.Append(tr8);

                TableRow tr9 = new TableRow();
                TableCell tr9tc1 = new TableCell("Egenskap");
                TableCell tr9tc2 = new TableCell("Tot./Uts.");
                TableCell tr9tc3 = new TableCell("Förmåga");
                TableCell tr9tc4 = new TableCell("Värde:");
                TableCell tr9tc5 = new TableCell("TP");
                TableCell tr9tc6 = new TableCell("Exp");
                TableCell tr9tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr9tc8 = new TableCell("TTP");
                TableCell tr9tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr9.Append(tr9tc1);
                tr9.Append(tr9tc2);
                tr9.Append(tr9tc3);
                tr9.Append(tr9tc4);
                tr9.Append(tr9tc5);
                tr9.Append(tr9tc6);
                tr9.Append(tr9tc7);
                tr9.Append(tr9tc8);
                tr9.Append(tr9tc9);
                table.Append(tr9);
                
                TableRow tr10 = new TableRow();
                TableCell tr10tc1 = new TableCell("Egenskap");
                TableCell tr10tc2 = new TableCell("Tot./Uts.");
                TableCell tr10tc3 = new TableCell("Förmåga");
                TableCell tr10tc4 = new TableCell("Värde:");
                TableCell tr10tc5 = new TableCell("TP");
                TableCell tr10tc6 = new TableCell("Exp");
                TableCell tr10tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr10tc8 = new TableCell("TTP");
                TableCell tr10tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr10.Append(tr10tc1);
                tr10.Append(tr10tc2);
                tr10.Append(tr10tc3);
                tr10.Append(tr10tc4);
                tr10.Append(tr10tc5);
                tr10.Append(tr10tc6);
                tr10.Append(tr10tc7);
                tr10.Append(tr10tc8);
                tr10.Append(tr10tc9);
                table.Append(tr10);

                TableRow tr11 = new TableRow();
                TableCell tr11tc1 = new TableCell("Egenskap");
                TableCell tr11tc2 = new TableCell("Tot./Uts.");
                TableCell tr11tc3 = new TableCell("Förmåga");
                TableCell tr11tc4 = new TableCell("Värde:");
                TableCell tr11tc5 = new TableCell("TP");
                TableCell tr11tc6 = new TableCell("Exp");
                TableCell tr11tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr11tc8 = new TableCell("TTP");
                TableCell tr11tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr11.Append(tr11tc1);
                tr11.Append(tr11tc2);
                tr11.Append(tr11tc3);
                tr11.Append(tr11tc4);
                tr11.Append(tr11tc5);
                tr11.Append(tr11tc6);
                tr11.Append(tr11tc7);
                tr11.Append(tr11tc8);
                tr11.Append(tr11tc9);
                table.Append(tr11);

                TableRow tr12 = new TableRow();
                TableCell tr12tc1 = new TableCell("Egenskap");
                TableCell tr12tc2 = new TableCell("Tot./Uts.");
                TableCell tr12tc3 = new TableCell("Förmåga");
                TableCell tr12tc4 = new TableCell("Värde:");
                TableCell tr12tc5 = new TableCell("TP");
                TableCell tr12tc6 = new TableCell("Exp");
                TableCell tr12tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr12tc8 = new TableCell("TTP");
                TableCell tr12tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr12.Append(tr12tc1);
                tr12.Append(tr12tc2);
                tr12.Append(tr12tc3);
                tr12.Append(tr12tc4);
                tr12.Append(tr12tc5);
                tr12.Append(tr12tc6);
                tr12.Append(tr12tc7);
                tr12.Append(tr12tc8);
                tr12.Append(tr12tc9);
                table.Append(tr12);

                TableRow tr13 = new TableRow();
                TableCell tr13tc1 = new TableCell("Egenskap");
                TableCell tr13tc2 = new TableCell("Tot./Uts.");
                TableCell tr13tc3 = new TableCell("Förmåga");
                TableCell tr13tc4 = new TableCell("Värde:");
                TableCell tr13tc5 = new TableCell("TP");
                TableCell tr13tc6 = new TableCell("Exp");
                TableCell tr13tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr13tc8 = new TableCell("TTP");
                TableCell tr13tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr13.Append(tr13tc1);
                tr13.Append(tr13tc2);
                tr13.Append(tr13tc3);
                tr13.Append(tr13tc4);
                tr13.Append(tr13tc5);
                tr13.Append(tr13tc6);
                tr13.Append(tr13tc7);
                tr13.Append(tr13tc8);
                tr13.Append(tr13tc9);
                table.Append(tr13);
                TableRow tr14 = new TableRow();
                TableCell tr14tc1 = new TableCell("Egenskap");
                TableCell tr14tc2 = new TableCell("Tot./Uts.");
                TableCell tr14tc3 = new TableCell("Förmåga");
                TableCell tr14tc4 = new TableCell("Värde:");
                TableCell tr14tc5 = new TableCell("TP");
                TableCell tr14tc6 = new TableCell("Exp");
                TableCell tr14tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr14tc8 = new TableCell("TTP");
                TableCell tr14tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr14.Append(tr14tc1);
                tr14.Append(tr14tc2);
                tr14.Append(tr14tc3);
                tr14.Append(tr14tc4);
                tr14.Append(tr14tc5);
                tr14.Append(tr14tc6);
                tr14.Append(tr14tc7);
                tr14.Append(tr14tc8);
                tr14.Append(tr14tc9);
                table.Append(tr14);
                TableRow tr15 = new TableRow();
                TableCell tr15tc1 = new TableCell("Egenskap");
                TableCell tr15tc2 = new TableCell("Tot./Uts.");
                TableCell tr15tc3 = new TableCell("Förmåga");
                TableCell tr15tc4 = new TableCell("Värde:");
                TableCell tr15tc5 = new TableCell("TP");
                TableCell tr15tc6 = new TableCell("Exp");
                TableCell tr15tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr15tc8 = new TableCell("TTP");
                TableCell tr15tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr15.Append(tr15tc1);
                tr15.Append(tr15tc2);
                tr15.Append(tr15tc3);
                tr15.Append(tr15tc4);
                tr15.Append(tr15tc5);
                tr15.Append(tr15tc6);
                tr15.Append(tr15tc7);
                tr15.Append(tr15tc8);
                tr15.Append(tr15tc9);
                table.Append(tr15);
                TableRow tr16 = new TableRow();
                TableCell tr16tc1 = new TableCell("Egenskap");
                TableCell tr16tc2 = new TableCell("Tot./Uts.");
                TableCell tr16tc3 = new TableCell("Förmåga");
                TableCell tr16tc4 = new TableCell("Värde:");
                TableCell tr16tc5 = new TableCell("TP");
                TableCell tr16tc6 = new TableCell("Exp");
                TableCell tr16tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr16tc8 = new TableCell("TTP");
                TableCell tr16tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr16.Append(tr16tc1);
                tr16.Append(tr16tc2);
                tr16.Append(tr16tc3);
                tr16.Append(tr16tc4);
                tr16.Append(tr16tc5);
                tr16.Append(tr16tc6);
                tr16.Append(tr16tc7);
                tr16.Append(tr16tc8);
                tr16.Append(tr16tc9);
                table.Append(tr16);
                TableRow tr17 = new TableRow();
                TableCell tr17tc1 = new TableCell("Egenskap");
                TableCell tr17tc2 = new TableCell("Tot./Uts.");
                TableCell tr17tc3 = new TableCell("Förmåga");
                TableCell tr17tc4 = new TableCell("Värde:");
                TableCell tr17tc5 = new TableCell("TP");
                TableCell tr17tc6 = new TableCell("Exp");
                TableCell tr17tc7 = new TableCell("Talanger(Se tabell för kostnader)");
                TableCell tr17tc8 = new TableCell("TTP");
                TableCell tr17tc9 = new TableCell("Färdigheter");
                ////append the new cell to the row
                tr17.Append(tr17tc1);
                tr17.Append(tr17tc2);
                tr17.Append(tr17tc3);
                tr17.Append(tr17tc4);
                tr17.Append(tr17tc5);
                tr17.Append(tr17tc6);
                tr17.Append(tr17tc7);
                tr17.Append(tr17tc8);
                tr17.Append(tr17tc9);
                table.Append(tr17);
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
                table.Append(tr1);

                // Append the table to the document.
                wordDocument.MainDocumentPart.Document.Body.Append(table);

                // Save changes to the MainDocumentPart.
                wordDocument.MainDocumentPart.Document.Save();


                return filename;
                //    var path = Path.Combine(
                //                      Directory.GetCurrentDirectory(),
                //                      "wwwroot", filename);

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
