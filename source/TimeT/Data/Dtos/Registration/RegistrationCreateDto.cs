namespace TimeT.Data.Dtos.Registration
{
    public class RegistrationCreateDto
    {
        public string userId { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string comment { get; set; }
        public int timeId { get; set; }
    }
}
