namespace Database
{
    public class Weather
    {
        public int Id { get; set; }
        public string MeasuredBy { get; set; } = string.Empty;
        public DateTime MeasurementDate { get; set; }
    }
}
