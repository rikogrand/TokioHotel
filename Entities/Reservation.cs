using System;

namespace TokioHotel.Entities;

public class Reservation
{
    public int Reservation_ID { get; set; }
    public DateTime StartReserv_Date { get; set; }
    public DateTime EndReserv_Date { get; set; }
    public int Statement { get; set; }
    public int Administrator { get; set; }
    public int Hotel_Room { get; set; }
}