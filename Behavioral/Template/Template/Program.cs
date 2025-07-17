using TemplatePattern.Reports;

Console.WriteLine("Generating PDF Report:");
ReportBase pdf = new PDFReport();
pdf.GenerateReport();

Console.WriteLine();

Console.WriteLine("Generating Excel Report:");
ReportBase excel = new ExcelReport();
excel.GenerateReport();