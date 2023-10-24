
using System;

namespace TokioHotel.Entities;

public class Review
{
    public int Review_ID { get; set; }
    public int Guest { get; set; }
    public int Rent { get; set; }
    public DateTime Date_Review { get; set; }
    public string Guest_Description { get; set;}    

}