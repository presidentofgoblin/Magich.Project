using Magic.Files.CSV;

namespace Magic.Files.Logic
{
    internal class AllianceBadgesData : Data
    {
        public AllianceBadgesData(CsvRow row, DataTable dt) : base(row, dt)
        {
            LoadData(this, GetType(), row);
        }

        public string IconExportName { get; set; }
        public string IconLayer0 { get; set; }
        public string IconLayer1 { get; set; }
        public string IconLayer2 { get; set; }
        public string IconSWF { get; set; }
        public string Name { get; set; }
    }
}
