using lesson24.Interface;

namespace lesson24.Models
{
    internal class Room : IGeneralInterface
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public int GuestCount { get; set; }
        public decimal Price { get; set; }
        public Hotel Hotel { get; set; }
        public static int RoomCount { get; set; } = 0;

        public Room(string roomNumber, int guestCount, decimal price, Hotel hotel)
        {
            RoomCount++;
            Id = RoomCount;
            RoomNumber = roomNumber;
            GuestCount = guestCount;
            Price = price;
            Hotel = hotel;

        }

        public string WriteInConsole()
        {
            return $"[{Id}] : {RoomNumber}, {RoomCount}, {Price}.";
        }

        public override string ToString()
        {
            return $"{Id} | {RoomNumber} | {GuestCount} | {Price} | {Hotel}";
        }
    }
}
