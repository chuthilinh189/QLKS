using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Threading;

namespace QLKSAPI.Models
{
    public class Helper
    {
        public static string EnCode(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputByte = Encoding.ASCII.GetBytes(input);
            byte[] outCode = md5.ComputeHash(inputByte);
            StringBuilder br = new StringBuilder();
            foreach (byte i in outCode)
            {
                br.Append(i.ToString("X2"));
            }
            return br.ToString();
        }

        public static string GetRandomCode(Component com, string txt)
        {
            return EnCode(string.Format("{0}{1}", com, txt));
        }

        public static void Write(string log, string place)
        {
            StreamWriter wr = null;
            try
            {
                DateTime date = DateTime.Now;
                string path = "";// string.Format("{0}\\logs.txt", AppDomainSetup.StartupPath);
                wr = new StreamWriter(path, true, Encoding.Unicode);
                string text = string.Format("{0} : {1} - {2}. {3} ", date.ToShortDateString(), date.ToShortTimeString(), log, place);
                wr.WriteLine(text);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                wr.Close();
                wr.Dispose();
            }
        }

        private static void HorizontalMerge(DocumentFormat.OpenXml.Wordprocessing.Table tb, TableRow row)
        {
            var cells = row.Descendants<DocumentFormat.OpenXml.Wordprocessing.TableCell>().ToList();
            cells[0].Descendants<DocumentFormat.OpenXml.Wordprocessing.Text>().FirstOrDefault().Text = "Chưa có dữ liệu";
            for (int j = 0; j < cells.Count; j++)
            {
                if (j == 0)
                {
                    TableCellProperties cellOneProperties = new TableCellProperties();
                    cellOneProperties.Append(new HorizontalMerge()
                    {
                        Val = MergedCellValues.Restart
                    });
                    cells.ElementAt(0).Append(cellOneProperties);
                }
                else
                {
                    TableCellProperties cellTwoProperties = new TableCellProperties();
                    cellTwoProperties.Append(new HorizontalMerge()
                    {
                        Val = MergedCellValues.Continue
                    });
                    cells.ElementAt(j).Append(cellTwoProperties);
                }
            }
            tb.Descendants<DocumentFormat.OpenXml.Wordprocessing.TableRow>().Last().InsertAfterSelf(row);
        }
        
    }
}
