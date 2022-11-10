using System.ComponentModel.DataAnnotations;

namespace TimeT.Data.Dtos.Time
{
    public class TimeUpdateDto
    {
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string type { get; set; }
        public bool visibility { get; set; }
        public bool register1 { get; set; }
        public bool register2 { get; set; }
        public int maxRegisterTime { get; set; }
        public int sectorInterval1 { get; set; }
        public int sectorInterval2 { get; set; }
    }
}
