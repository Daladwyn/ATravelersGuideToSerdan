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
using System.Linq;
using System;

namespace ATravelersGuideToSerdan.Services
{
    public class FileSerdan : IFileSerdan
    {
        public string CreateCharacterSheet(CreatePlayer1ViewModel CharacterToPrint)
        {
            var filename = CharacterToPrint.CharacterName + ".docx";
            var path = Path.Combine(
                          Directory.GetCurrentDirectory(),
                          "wwwroot", filename);
            PageOrientationValues newOrientation = PageOrientationValues.Landscape;

            using (var wordDocument = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();



                mainPart.Document = new Document();


                Body body = mainPart.Document.AppendChild(new Body());

                SectionProperties sectProps = new SectionProperties();
                PageSize pageSize = new PageSize() { Width = 16838U, Height = 11906U, Orient = PageOrientationValues.Landscape };
                PageMargin pageMargin = new PageMargin() { Top = 720, Right = 720U, Bottom = 720, Left = 720U };

                sectProps.Append(pageSize);
                sectProps.Append(pageMargin);
                body.Append(sectProps);

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

                table.Append(tr1);
                ////Create a new row in tablecell tc2
                TableRow tr2 = new TableRow();

                ////Create a new cell with the text "Namn:"
                TableCell tr2tc1 = new TableCell();
                TableCell tr2tc2 = new TableCell();
                TableCell tr2tc3 = new TableCell();
                TableCell tr2tc4 = new TableCell();
                TableCell tr2tc5 = new TableCell();
                TableCell tr2tc6 = new TableCell();
                TableCell tr2tc7 = new TableCell();
                TableCell tr2tc8 = new TableCell();
                TableCell tr2tc9 = new TableCell();
                tr2tc1.Append(new Paragraph(new Run(new Text("Egenskap"))));
                tr2tc2.Append(new Paragraph(new Run(new Text("Tot./Uts."))));
                tr2tc3.Append(new Paragraph(new Run(new Text("Förmåga"))));
                tr2tc4.Append(new Paragraph(new Run(new Text("Värde:"))));
                tr2tc5.Append(new Paragraph(new Run(new Text("TP"))));
                tr2tc6.Append(new Paragraph(new Run(new Text("Exp"))));
                tr2tc7.Append(new Paragraph(new Run(new Text("Talanger(Se tabell för kostnader)"))));
                tr2tc8.Append(new Paragraph(new Run(new Text("TTP"))));
                tr2tc9.Append(new Paragraph(new Run(new Text("Färdigheter"))));
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
                TableCell tr3tc1 = new TableCell(new Paragraph(new Run(new Text("Koordination/"))));
                TableCell tr3tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.KoordinationMotorikTot.ToString()))));
                TableCell tr3tc3 = new TableCell(new Paragraph(new Run(new Text("Vapen"))));
                TableCell tr3tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WeaponValue.ToString()))));
                TableCell tr3tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WeaponTp.ToString()))));
                TableCell tr3tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WeaponExp.ToString())))); ;
                TableCell tr3tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WeaponTalang))));
                TableCell tr3tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WeaponTTp.ToString()))));
                TableCell tr3tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WeaponSkills))));
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
                TableCell tr4tc1 = new TableCell(new Paragraph(new Run(new Text("Motorik"))));
                TableCell tr4tc2 = new TableCell(new Paragraph(new Run(new Text("/"))));
                TableCell tr4tc3 = new TableCell(new Paragraph(new Run(new Text("Skjutvapen"))));
                TableCell tr4tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.BalisticValue.ToString()))));
                TableCell tr4tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.BalisticTp.ToString()))));
                TableCell tr4tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.BalisticExp.ToString()))));
                TableCell tr4tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.BalisticTalang))));
                TableCell tr4tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.BalisticTTp.ToString()))));
                TableCell tr4tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.BalisticSkills))));
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
                TableCell tr5tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr5tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.KoordinationMotorikUts.ToString()))));
                TableCell tr5tc3 = new TableCell(new Paragraph(new Run(new Text("Finmotorik"))));
                TableCell tr5tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.FineMotorValue.ToString()))));
                TableCell tr5tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.FineMotorTp.ToString()))));
                TableCell tr5tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.FineMotorExp.ToString()))));
                TableCell tr5tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.FineMotorTalang))));
                TableCell tr5tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.FineMotorTTp.ToString()))));
                TableCell tr5tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.FineMotorSkills))));
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
                TableCell tr6tc1 = new TableCell(new Paragraph(new Run(new Text("Kropps-"))));
                TableCell tr6tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysiqueTot.ToString()))));
                TableCell tr6tc3 = new TableCell(new Paragraph(new Run(new Text("Fysik"))));
                TableCell tr6tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysicsValue.ToString()))));
                TableCell tr6tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysicsTp.ToString()))));
                TableCell tr6tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysicsExp.ToString()))));
                TableCell tr6tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysicsTalang))));
                TableCell tr6tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysicsTTp.ToString()))));
                TableCell tr6tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysicsSkills))));
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
                TableCell tr7tc1 = new TableCell(new Paragraph(new Run(new Text("Byggnad"))));
                TableCell tr7tc2 = new TableCell(new Paragraph(new Run(new Text("/"))));
                TableCell tr7tc3 = new TableCell(new Paragraph(new Run(new Text("Styrka"))));
                TableCell tr7tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.StrenghtValue.ToString()))));
                TableCell tr7tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.StrenghtTp.ToString()))));
                TableCell tr7tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.StrenghtExp.ToString()))));
                TableCell tr7tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.StrenghtTalang))));
                TableCell tr7tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.StrenghtTTp.ToString()))));
                TableCell tr7tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.StrenghtSkills))));
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
                TableCell tr8tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr8tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PhysiqueUts.ToString()))));
                TableCell tr8tc3 = new TableCell(new Paragraph(new Run(new Text("Rörlighet"))));
                TableCell tr8tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MobilityValue.ToString()))));
                TableCell tr8tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MobilityTp.ToString()))));
                TableCell tr8tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MobilityExp.ToString()))));
                TableCell tr8tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MobilityTalang))));
                TableCell tr8tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MobilityTTp.ToString()))));
                TableCell tr8tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MobilitySkills))));
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
                TableCell tr9tc1 = new TableCell(new Paragraph(new Run(new Text("Psyke"))));
                TableCell tr9tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PsykeTot.ToString()))));
                TableCell tr9tc3 = new TableCell(new Paragraph(new Run(new Text("Vilja"))));
                TableCell tr9tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WillValue.ToString()))));
                TableCell tr9tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WillTp.ToString()))));
                TableCell tr9tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WillExp.ToString()))));
                TableCell tr9tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WillTalang))));
                TableCell tr9tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WillTTp.ToString()))));
                TableCell tr9tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.WillSkills))));
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
                TableCell tr10tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr10tc2 = new TableCell(new Paragraph(new Run(new Text("/"))));
                TableCell tr10tc3 = new TableCell(new Paragraph(new Run(new Text("Kreativitet"))));
                TableCell tr10tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CreativityValue.ToString()))));
                TableCell tr10tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CreativityTp.ToString()))));
                TableCell tr10tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CreativityExp.ToString()))));
                TableCell tr10tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CreativityTalang))));
                TableCell tr10tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CreativityTTp.ToString()))));
                TableCell tr10tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CreativitySkills))));
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
                TableCell tr11tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr11tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PsykeUts.ToString()))));
                TableCell tr11tc3 = new TableCell(new Paragraph(new Run(new Text("Bildning"))));
                TableCell tr11tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationValue.ToString()))));
                TableCell tr11tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationTp.ToString()))));
                TableCell tr11tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationExp.ToString()))));
                TableCell tr11tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationTalang))));
                TableCell tr11tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationTTp.ToString()))));
                TableCell tr11tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationSkills))));
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
                TableCell tr12tc1 = new TableCell(new Paragraph(new Run(new Text("Perception"))));
                TableCell tr12tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PerceptionTot.ToString()))));
                TableCell tr12tc3 = new TableCell(new Paragraph(new Run(new Text("Intuition"))));
                TableCell tr12tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.IntuitionValue.ToString()))));
                TableCell tr12tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.IntuitionTp.ToString()))));
                TableCell tr12tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.IntuitionExp.ToString()))));
                TableCell tr12tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationTalang))));
                TableCell tr12tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.IntuitionTTp.ToString()))));
                TableCell tr12tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.EducationSkills))));
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
                TableCell tr13tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr13tc2 = new TableCell(new Paragraph(new Run(new Text("/"))));
                TableCell tr13tc3 = new TableCell(new Paragraph(new Run(new Text("Magisk syn"))));
                TableCell tr13tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MagicVisionValue.ToString()))));
                TableCell tr13tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MagicVisionTp.ToString()))));
                TableCell tr13tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MagicVisionExp.ToString()))));
                TableCell tr13tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MagicVisionTalang))));
                TableCell tr13tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MagicVisionTTp.ToString()))));
                TableCell tr13tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.MagicVisionSkills))));
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
                TableCell tr14tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr14tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.PerceptionUts.ToString()))));
                TableCell tr14tc3 = new TableCell(new Paragraph(new Run(new Text("Uppm."))));
                TableCell tr14tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.AttentionValue.ToString()))));
                TableCell tr14tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.AttentionTp.ToString()))));
                TableCell tr14tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.AttentionExp.ToString()))));
                TableCell tr14tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.AttentionTalang))));
                TableCell tr14tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.AttentionTTp.ToString()))));
                TableCell tr14tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.AttentionSkills))));
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
                TableCell tr15tc1 = new TableCell(new Paragraph(new Run(new Text("Sociala"))));
                TableCell tr15tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.SocialTot.ToString()))));
                TableCell tr15tc3 = new TableCell(new Paragraph(new Run(new Text("Utstrålning"))));
                TableCell tr15tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CharismaValue.ToString()))));
                TableCell tr15tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CharismaTp.ToString()))));
                TableCell tr15tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CharismaExp.ToString()))));
                TableCell tr15tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CharismaTalang))));
                TableCell tr15tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CharismaTTp.ToString()))));
                TableCell tr15tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.CharismaSkills))));
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
                TableCell tr16tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr16tc2 = new TableCell(new Paragraph(new Run(new Text("/"))));
                TableCell tr16tc3 = new TableCell(new Paragraph(new Run(new Text("Insikt"))));
                TableCell tr16tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.InsightValue.ToString()))));
                TableCell tr16tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.InsightTp.ToString()))));
                TableCell tr16tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.InsightExp.ToString()))));
                TableCell tr16tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.InsightTalang))));
                TableCell tr16tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.InsightTTp.ToString()))));
                TableCell tr16tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.InsightSkills))));
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
                TableCell tr17tc1 = new TableCell(new Paragraph(new Run(new Text(""))));
                TableCell tr17tc2 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.SocialUts.ToString()))));
                TableCell tr17tc3 = new TableCell(new Paragraph(new Run(new Text("Motstånd"))));
                TableCell tr17tc4 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.ResistanceValue.ToString()))));
                TableCell tr17tc5 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.ResistanceTp.ToString()))));
                TableCell tr17tc6 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.ResistanceExp.ToString()))));
                TableCell tr17tc7 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.ResistanceTalang))));
                TableCell tr17tc8 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.ResistanceTTp.ToString()))));
                TableCell tr17tc9 = new TableCell(new Paragraph(new Run(new Text(CharacterToPrint.ResistanceSkills))));
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

                //para.Append(table);


                // Append the table to the document.
                wordDocument.MainDocumentPart.Document.Body.Append(table);

                // Save changes to the MainDocumentPart.
                wordDocument.MainDocumentPart.Document.Save();

                bool documentChanged = false;

                var docPart = wordDocument.MainDocumentPart;
                var sections = docPart.Document.Descendants<SectionProperties>();

                foreach (SectionProperties sectPr in sections)
                {
                    bool pageOrientationChanged = false;

                    PageSize pgSz = sectPr.Descendants<PageSize>().FirstOrDefault();
                    if (pgSz != null)
                    {
                        if (pgSz.Orient == null)
                        {
                            if (newOrientation != PageOrientationValues.Portrait)
                            {
                                pageOrientationChanged = true;
                                documentChanged = true;
                                pgSz.Orient =
                                    new EnumValue<PageOrientationValues>(newOrientation);
                            }
                        }
                        else
                        {
                            if (pgSz.Orient.Value != newOrientation)
                            {
                                pgSz.Orient.Value = newOrientation;
                                pageOrientationChanged = true;
                                documentChanged = true;
                            }
                        }
                    }
                    if (pageOrientationChanged)
                    {
                        // Changing the orientation is not enough. You must also 
                        // change the page size.
                        var width = pgSz.Width;
                        var height = pgSz.Height;
                        pgSz.Width = height;
                        pgSz.Height = width;

                        PageMargin pgMar = sectPr.Descendants<PageMargin>().FirstOrDefault();
                        if (pgMar != null)
                        {
                            var top = pgMar.Top.Value;
                            var bottom = pgMar.Bottom.Value;
                            var left = pgMar.Left.Value;
                            var right = pgMar.Right.Value;

                            pgMar.Top = new Int32Value((int)left);
                            pgMar.Bottom = new Int32Value((int)right);
                            pgMar.Left = new UInt32Value((uint)System.Math.Max(0, bottom));
                            pgMar.Right = new UInt32Value((uint)System.Math.Max(0, top));
                        }
                    }
                    if (documentChanged)
                    {
                        wordDocument.MainDocumentPart.Document.Save();
                    }
                }

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
