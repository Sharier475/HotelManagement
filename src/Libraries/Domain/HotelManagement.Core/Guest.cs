using HotelManagement.Shared.Common;

namespace HotelManagement.Model;

public class Guest : BaseEntity,IEntity
{
    public string? GuestName { get; set; }

    public double RoomPrice { get; set; }
    public string? RoomType { get; set; }
    public int Id { get; set; }

}
