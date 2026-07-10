namespace rideshare_practice.Models
{
    public class User
    {
        public int Id { get; set; }
        public string DbEncryptedPassword { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; }
    }
    public class Driver
    {
        //use user ID as primary
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int DriverRating { get; set; }
        public string ProfilePhotoLink { get; set; } = string.Empty;
    }
    public class RideInstance
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User user { get; set; } = null!;

        public int RideDatum { get; set; }
        public RideDatum Datum { get; set; } = null!;
    }

    public class RideDatum
    {
        public int Id { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; } = null!;
    }
}
