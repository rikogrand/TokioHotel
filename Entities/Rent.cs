namespace TokioHotel.Entities;

public class Rent
{
    public int Rent_ID { get; set; }
    public int Reservation { get; set; }
    public string Guest { get; set; }
    public int Price { get; set; }
    public int Payment { get; set; }
    public int Hotel_Room { get; set; }
}