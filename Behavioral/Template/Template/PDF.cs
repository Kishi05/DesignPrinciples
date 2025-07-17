namespace TemplatePattern.Reports
{
    /// <summary>
    /// Concrete implementation for PDF report.
    /// </summary>
    internal class PDFReport : ReportBase
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data for PDF Report...");
        }

        protected override void FormatContent()
        {
            Console.WriteLine("Formatting content as per PDF layout...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as PDF...");
        }
    }
}
