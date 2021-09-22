namespace U210921X2
{
    public class Car//Making this here instead of Form1 in case another file needs to access this class
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Km { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
    }
}