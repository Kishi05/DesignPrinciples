namespace TemplatePattern.Reports
{
    /// <summary>
    /// Concrete implementation for Excel report.
    /// </summary>
    internal class ExcelReport : ReportBase
    {
        protected override void LoadData()
        {
            Console.WriteLine("Loading data for Excel Report...");
        }

        protected override void FormatContent()
        {
            Console.WriteLine("Formatting content for Excel grid layout...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as Excel file...");
        }
    }
}
