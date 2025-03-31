public class Weather
{
    public int Id { get; set; }
    public required string City { get; set; }
    public required string Temperature { get; set; }
    public required string Condition { get; set; }
    public DateTime Date { get; set; }
}
