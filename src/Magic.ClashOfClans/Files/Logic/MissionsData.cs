using Magic.Files.CSV;

namespace Magic.Files.Logic
{
    internal class MissionsData : Data
    {
        public MissionsData(CsvRow row, DataTable dt) : base(row, dt)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }
    }
}
