using HotelManagement.Shared.Common;

namespace HotelManagement.Services.Model;

public class VmGuest : IVm
{
    public int Id { get; set ; }
    public string? GuestName { get; set ; }
    public double RoomPrice { get; set; }
    public string? RoomType { get; set; }
}
