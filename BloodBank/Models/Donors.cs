namespace BloodBank.Models
{
    public class Donors
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public string BloodType { get; set; }
        public string HRFactor { get; set; }
        public List<Donation> donations { get; set; }
        public string Address { get; set; }
    }
}
