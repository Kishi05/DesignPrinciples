namespace TemplatePattern.Reports
{
    /// <summary>
    /// Template base class defining the skeleton of report generation.
    /// </summary>
    internal abstract class ReportBase
    {
        // Template method
        public void GenerateReport()
        {
            LoadData();
            FormatContent();
            ExportReport();
        }

        /// <summary>
        /// Loads required data for the report.
        /// </summary>
        protected abstract void LoadData();

        /// <summary>
        /// Formats the content in a specific style.
        /// </summary>
        protected abstract void FormatContent();

        /// <summary>
        /// Exports the report in required format.
        /// </summary>
        protected abstract void ExportReport();
    }
}
