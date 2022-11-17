namespace TimeT.Data.Dtos.Registration
{
    public class RegistrationCreateDto
    {
        public string userId { get; set; }
        public string type { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string comment { get; set; }
        public int timeId { get; set; }
    }
}
