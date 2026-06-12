using Newtonsoft.Json;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHotel.backend
{
    // ── Replace the Room class in AuthService.cs with this ────────────────────────

    [Table("rooms")]
    public class Room : BaseModel
    {
    
        [PrimaryKey("id", true)]
        public Guid Id { get; set; }

        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Column("room_name")]
        public string RoomName { get; set; }

        [Column("room_description")]
        public string RoomDescription { get; set; }

        [Column("weekday_price_3h")]
        public decimal WeekdayPrice3h { get; set; }

        [Column("weekend_price_3h")]
        public decimal WeekendPrice3h { get; set; }

        [Column("weekday_price_12h")]
        public decimal WeekdayPrice12h { get; set; }

        [Column("weekend_price_12h")]
        public decimal WeekendPrice12h { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("room_image_url")]
        public string RoomImageUrl { get; set; }
    }

    [Table("profiles")]
    public class UserProfile : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("role")]
        public string Role { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("contact_num")]
        public string ContactNum { get; set; }
    }

    public class RoomDto
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public Guid Id { get; set; }

        [Newtonsoft.Json.JsonProperty("room_number")]
        public string RoomNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("room_name")]
        public string RoomName { get; set; }

        [Newtonsoft.Json.JsonProperty("room_description")]
        public string RoomDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("weekday_price_3h")]
        public decimal WeekdayPrice3h { get; set; }

        [Newtonsoft.Json.JsonProperty("weekend_price_3h")]
        public decimal WeekendPrice3h { get; set; }

        [Newtonsoft.Json.JsonProperty("weekday_price_12h")]
        public decimal WeekdayPrice12h { get; set; }

        [Newtonsoft.Json.JsonProperty("weekend_price_12h")]
        public decimal WeekendPrice12h { get; set; }

        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("room_image_url")]
        public string RoomImageUrl { get; set; }
    }


    internal class AuthService
    {
        private static readonly string url =
            "https://crkkkgtlyhxcrbjjdciv.supabase.co";

        private static readonly string key =
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImNya2trZ3RseWh4Y3JiampkY2l2Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3ODA5MTI4NjAsImV4cCI6MjA5NjQ4ODg2MH0.Y_LQhXhhaMHsCJse27PQLWREVSqwmIPI-uFkgPMSaOg";

        private static Supabase.Client _client;

        private static readonly HttpClient _http = new HttpClient();
        private static bool _httpConfigured = false;


        private static void EnsureHttpConfigured()
        {
            if (_httpConfigured) return;
            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("apikey", key);
            _http.DefaultRequestHeaders.Add("Authorization", "Bearer " + key);
            _http.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _httpConfigured = true;
        }

        public static async Task<Supabase.Client> Initialize()
        {
            if (_client != null)
                return _client;

            var options = new SupabaseOptions
            {
                AutoRefreshToken = true
            };

            _client = new Supabase.Client(url, key, options);

            await _client.InitializeAsync();

            return _client;
        }

        public static async Task<string> RegisterUser(string email, string password)
        {
            try
            {
                var supabase = await Initialize();

                var response = await supabase.Auth.SignUp(email, password);

                if (response.User == null)
                    return "Signup failed";

                var userId = Guid.Parse(response.User.Id);

                // (prevents duplicates + guarantees profile exists)
                await supabase
                    .From<UserProfile>()
                    .Upsert(new UserProfile
                    {
                        Id = userId,
                        Email = email,
                        Role = "user"
                    });

                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<(string Role, string UserId)> SignIn(
            string email,
            string password)
        {
            try
            {
                var supabase = await Initialize();

                var session =
                    await supabase.Auth.SignInWithPassword(
                        email,
                        password);

                if (session?.User == null)
                    return ("Invalid email or password.", null);

                string userId = session.User.Id;

                if (!Guid.TryParse(userId, out Guid profileId))
                    return ("Invalid UUID format.", null);

                var response = await supabase
                    .From<UserProfile>()
                    .Filter(
                        "id",
                        Supabase.Postgrest.Constants.Operator.Equals,
                        profileId.ToString()
                    )
                    .Get();

                string role = "user";

                if (response.Models.Count > 0)
                {
                    role = response.Models[0].Role ?? "user";
                }

                return (role, userId);
            }
            catch (Exception ex)
            {
                return ("Error: " + ex.Message, null);
            }
        }

        public static async Task<List<Room>> GetRoomsAsync()
        {
            EnsureHttpConfigured(); // the method from the earlier fix

            var response = await _http.GetAsync(
                url + "/rest/v1/rooms?select=*&status=eq.available&order=room_number.asc");

            var json = await response.Content.ReadAsStringAsync();

            // Deserialize manually so id maps correctly
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RoomDto>>(json);

            // Map to Room objects with Id properly set
            var rooms = new System.Collections.Generic.List<Room>();
            foreach (var dto in list)
            {
                rooms.Add(new Room
                {
                    Id = dto.Id,           // ✅ real UUID from DB
                    RoomNumber = dto.RoomNumber,
                    RoomName = dto.RoomName,
                    RoomDescription = dto.RoomDescription,
                    WeekdayPrice3h = dto.WeekdayPrice3h,
                    WeekendPrice3h = dto.WeekendPrice3h,
                    WeekdayPrice12h = dto.WeekdayPrice12h,
                    WeekendPrice12h = dto.WeekendPrice12h,
                    Status = dto.Status,
                    RoomImageUrl = dto.RoomImageUrl,
                });
            }
            return rooms;
        }

        // ── Simple DTO for raw JSON deserialization ───────────────────────────────────

        public static async Task<string> SaveRoom(Room room)
        {
            try
            {
                EnsureHttpConfigured();

                var payload = new
                {
                    // ✅ No id field — let the DB generate it via uuid_generate_v4()
                    room_number = room.RoomNumber,
                    room_name = room.RoomName,
                    room_description = room.RoomDescription,
                    weekday_price_3h = room.WeekdayPrice3h,
                    weekend_price_3h = room.WeekendPrice3h,
                    weekday_price_12h = room.WeekdayPrice12h,
                    weekend_price_12h = room.WeekendPrice12h,
                    status = room.Status,
                    room_image_url = room.RoomImageUrl,
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var req = new HttpRequestMessage(HttpMethod.Post,
                    url + "/rest/v1/rooms");
                req.Content = content;
                req.Headers.Add("Prefer", "return=minimal");

                var response = await _http.SendAsync(req);

                if (response.IsSuccessStatusCode)
                    return "success";

                var error = await response.Content.ReadAsStringAsync();

                // ✅ Now 23505 will actually mean room_number is a duplicate
                return error;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        public static async Task<string> UploadRoomImage(
            byte[] fileData,
            string fileName)
        {
            try
            {
                var supabase = await Initialize();

                await supabase.Storage
                    .From("room-images")
                    .Upload(fileData, fileName);

                return supabase.Storage
                    .From("room-images")
                    .GetPublicUrl(fileName);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> SaveBooking(Booking booking)
        {
            try
            {
                EnsureHttpConfigured();

                var payload = new
                {
                    room_id = booking.RoomId.ToString(),
                    room_name = booking.RoomName,
                    user_id = booking.UserId,
                    check_in = booking.CheckIn.ToString("o"),
                    duration_hours = booking.DurationHours,
                    total_price = booking.TotalPrice,
                    status = booking.Status ?? "pending",

                  
                    created_at = DateTime.UtcNow.ToString("o")
                };

                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var req = new HttpRequestMessage(HttpMethod.Post,
                    url + "/rest/v1/bookings");

                req.Content = content;
                req.Headers.Add("Prefer", "return=minimal");

                var response = await _http.SendAsync(req);

                if (response.IsSuccessStatusCode)
                    return "success";

                var error = await response.Content.ReadAsStringAsync();
                return error;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<List<Booking>> GetAllBookingsAsync()
        {
            var supabase = await Initialize();
            var response = await supabase
                .From<Booking>()
                .Get();
            return response.Models;
        }

        public static async Task<string> ApproveBooking(Guid bookingId)
        {
            try
            {
                var supabase = await Initialize();

                // 1. Get booking first (to know roomId)
                var booking = await supabase
                    .From<Booking>()
                    .Where(x => x.Id == bookingId)
                    .Single();

                // 2. Update booking status → APPROVED
                await supabase
                    .From<Booking>()
                    .Where(x => x.Id == bookingId)
                    .Set(x => x.Status, "approved")
                    .Update();

                // 3. Update room status → OCCUPIED
                await SetRoomStatus(booking.RoomId, "occupied");

                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> RejectBooking(Guid bookingId)
        {
            try
            {
                var supabase = await Initialize();

                // 1. Get booking
                var booking = await supabase
                    .From<Booking>()
                    .Where(x => x.Id == bookingId)
                    .Single();

                // 2. Update booking status → REJECTED
                await supabase
                    .From<Booking>()
                    .Where(x => x.Id == bookingId)
                    .Set(x => x.Status, "rejected")
                    .Update();

                // 3. Room becomes AVAILABLE again
                await SetRoomStatus(booking.RoomId, "available");

                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> UpdateRoom(Room room)
        {
            try
            {
                EnsureHttpConfigured();

                var payload = new
                {
                    room_number = room.RoomNumber,
                    room_name = room.RoomName,
                    room_description = room.RoomDescription,
                    weekday_price_3h = room.WeekdayPrice3h,
                    weekend_price_3h = room.WeekendPrice3h,
                    weekday_price_12h = room.WeekdayPrice12h,
                    weekend_price_12h = room.WeekendPrice12h,
                    status = room.Status,
                    room_image_url = room.RoomImageUrl
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(payload);

                var req = new HttpRequestMessage(
                    new HttpMethod("PATCH"),
                    url + "/rest/v1/rooms?id=eq." + room.Id
                );

                req.Content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                req.Headers.Add("Prefer", "return=minimal");

                var response = await _http.SendAsync(req);

                if (response.IsSuccessStatusCode)
                    return "success";

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> DeleteRoom(Guid roomId)
        {
            try
            {
                EnsureHttpConfigured();

                var req = new HttpRequestMessage(
                    HttpMethod.Delete,
                    url + "/rest/v1/rooms?id=eq." + roomId
                );

                req.Headers.Add("Prefer", "return=minimal");

                var response = await _http.SendAsync(req);

                if (response.IsSuccessStatusCode)
                    return "success";

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<UserProfile> GetProfileById(Guid userId)
        {
            try
            {
                var supabase = await Initialize();

                var response = await supabase
                    .From<UserProfile>()
                    .Where(x => x.Id == userId)
                    .Single();

                return response;
            }
            catch
            {
                return null;
            }
        }
        public static async Task<List<Booking>> GetUserRecentBookings(Guid userId)
        {
            try
            {
                var supabase = await Initialize();

                var response = await supabase
                    .From<Booking>()
                    .Filter("user_id", Supabase.Postgrest.Constants.Operator.Equals, userId.ToString())
                    .Order("created_at", Supabase.Postgrest.Constants.Ordering.Descending)
                    .Limit(5)
                    .Get();

                return response.Models;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Booking>();
            }
        }

        public static async Task<string> UpdateProfile(UserProfile profile)
        {
            try
            {
                var supabase = await Initialize();

                await supabase
                    .From<UserProfile>()
                    .Update(profile);

                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<List<BookingWithProfile>> GetBookingsWithProfileAsync()
        {
            var supabase = await Initialize();

            var response = await supabase
                .From<BookingWithProfile>()
                .Select("*, profiles(*)")
                .Get();

            return response.Models;
        }

        public static async Task<string> SetRoomStatus(Guid roomId, string status)
        {
            try
            {
                EnsureHttpConfigured();

                var json = JsonConvert.SerializeObject(new
                {
                    status = status
                });

                var req = new HttpRequestMessage(
                    new HttpMethod("PATCH"),
                    url + "/rest/v1/rooms?id=eq." + roomId
                );

                req.Content = new StringContent(json, Encoding.UTF8, "application/json");

                req.Headers.Add("Prefer", "return=minimal");

                var response = await _http.SendAsync(req);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return "FAILED: " + result;

                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> CancelBooking(Guid bookingId)
        {
            try
            {
                var supabase = await Initialize();

                // Get booking first
                var booking = await supabase
                    .From<Booking>()
                    .Where(x => x.Id == bookingId)
                    .Single();

                if (booking == null)
                    return "Booking not found.";

                // Update booking status
                await supabase
                    .From<Booking>()
                    .Where(x => x.Id == bookingId)
                    .Set(x => x.Status, "cancelled")
                    .Update();

                // Optional: make room available again
                await SetRoomStatus(booking.RoomId, "available");

                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}