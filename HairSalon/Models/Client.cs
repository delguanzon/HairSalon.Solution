namespace HairSalon.Models
{
  public class Client
  {
    // properties, constructors, methods, etc. go here
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ContactNumber { get; set; }
    public string Status { get; set; }
    public string DateCreated{ get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }

  }
}