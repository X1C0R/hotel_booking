using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace BookHotel.backend
{
    [Table("bookings")]
    public class Booking : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("room_id")]
        public Guid RoomId { get; set; }

        [Column("room_name")]
        public string RoomName { get; set; }

        [Column("user_id")] // ₱ Maps directly to your new database tracking column
        public string UserId { get; set; }

        [Column("check_in")]
        public DateTime CheckIn { get; set; }

        [Column("duration_hours")]
        public int DurationHours { get; set; }

        [Column("total_price")]
        public decimal TotalPrice { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class BookingWithProfile : Booking
    {
        [Newtonsoft.Json.JsonProperty("profiles")]
        public UserProfile profile { get; set; }
    }
}