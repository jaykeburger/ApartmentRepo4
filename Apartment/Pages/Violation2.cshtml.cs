using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace Apartment.Pages
{
    public class Violation2Model : PageModel
    {
        public void OnGet()
        {
        }
        public string csvFile = "C:\\Users\\Jayke\\source\\repos\\ApartmentRepo4\\Apartment\\wwwroot\\smallviolations.csv";
        public string GetHtmlFromCsvFile(string csvFile)
        {
            return GetHtmlFromCsv(System.IO.File.ReadAllLines(csvFile));
        }
        public string GetHtmlFromCsv(string[] csvLines)
        {
            var headerLine = csvLines[0];
            var columns = headerLine.Split(',').Select((v, i) => new { ColumnName = v, ColumnIndex = i });
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<table>");
            sb.AppendLine("<thead>");
            sb.AppendLine("</thead>");
            foreach (var column in columns)
            {
                sb.AppendLine("<th>" + column.ColumnName + "</th>");
            }
            sb.AppendLine("<tbody>");
            var dataLines = csvLines.Skip(1);
            dataLines.ToList().ForEach(line =>
            {
                var data = line.Split(",");
                sb.AppendLine("<tr>");
                foreach (var column in columns)
                {
                    sb.AppendLine("<td>" + data[column.ColumnIndex] + "</td>");
                }
                sb.AppendLine("</tr>");
            });
            sb.AppendLine("</tbody>");
            sb.AppendLine("</table>");

            return sb.ToString();
        }
    }
}
