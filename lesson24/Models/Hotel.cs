using lesson24.Interface;

namespace lesson24.Models
{
    internal class Hotel : IGeneralInterface
    {
        public int Id { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public List<Room> Rooms { get; set; } = new List<Room>();
        public static int HotelCount { get; set; } = 0;

        public Hotel(string hotelName)
        {
            HotelCount++;
            Id = HotelCount;
            HotelName = hotelName;
        }

        public string WriteInConsole()
        {
            return $"[{Id}] : {HotelName}";
        }

        public override string ToString()
        {
            return $"{Id}| {HotelName}";
        }
    }
}
