using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ATravelersGuideToSerdan.ViewModels;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ATravelersGuideToSerdan.Services
{
    public class FileSerdan : IFileSerdan
    {
        public string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint, string filepath)
        {
            string wordFinalDocument;
            using (var wordDocument = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
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
                tc1.Append(new Paragraph(new Run(new Text("Serdan"))));

                // Append the table cell to the table row.
                tr.Append(tc1);

                // Create a second table cell by copying the OuterXml value of the first table cell.
                //TableCell tc2 = new TableCell(tc1.OuterXml);
                TableCell tc2 = new TableCell();

                //Create a new row in tablecell tc2
                TableRow undertr1 = new TableRow();

                //Create a new cell with the text "Namn:"
                TableCell undertr1tc1 = new TableCell("Namn: " + CharacterToPrint.CharacterName);

                //append the new cell to the row
                undertr1.Append(undertr1tc1);

                //create a new cell with the text "Spelare:"
                TableCell undertr1tc2 = new TableCell("Spelare: " + CharacterToPrint.PlayerName);

                //append the new cell to the row
                undertr1.Append(undertr1tc2);

                //create a second row within the cell
                tc2.Append(undertr1);

                //Create a new row in tablecell tc2
                TableRow undertr2 = new TableRow();

                //create a new cell with the text "Beskrivning:"
                TableCell undertr2tc1 = new TableCell("Beskrivning:");

                //Append the new cell to the second row in tc2
                undertr2.Append(undertr2tc1);

                //Append the second row to tc2
                tc2.Append(undertr2);

                //Create a new row in tablecell tc2
                TableRow undertr3 = new TableRow();

                //append the third row to tc2
                tc2.Append(undertr3);

                // Append the table cell to the table row.
                tr.Append(tc2);

                //Create a third cell in the first row
                TableCell tc3 = new TableCell();

                //append tc3 to tr
                tr.Append(tc3);

                //create 3 rows with first row with text "fysisk skada"

                //Create a fourth cell in the first row
                TableCell tc4 = new TableCell();

                //create 3 rows with first row with text "Själ skada"

                //Append tc4 to tr
                tr.Append(tc4);

                // Append the table row to the table.
                table.Append(tr);

                // Append the table to the document.
                wordDocument.MainDocumentPart.Document.Body.Append(table);

                // Save changes to the MainDocumentPart.
                wordDocument.MainDocumentPart.Document.Save();

                // Insert other code here. 
                wordFinalDocument = wordDocument.ToString();
            }
            //return wordFinalDocument;
            try
            {
                File.WriteAllText("c:/SerdanCharacter.docx", wordFinalDocument);
                //File.WriteAllText(filepath, wordFinalDocument);
            }
            catch (Exception)
            {

                throw;
            }
            return wordFinalDocument;

        }
    }
}
