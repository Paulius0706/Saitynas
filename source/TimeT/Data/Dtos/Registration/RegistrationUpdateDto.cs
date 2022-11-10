namespace TimeT.Data.Dtos.Registration
{
    public class RegistrationUpdateDto
    {
        public string userId { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string comment { get; set; }
    }
}
