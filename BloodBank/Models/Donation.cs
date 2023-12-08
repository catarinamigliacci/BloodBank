namespace BloodBank.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public DateTime DonationDate { get; set; }
        public int AmountML { get; set; }
        public Donors Donors { get; set; }

    }
}
