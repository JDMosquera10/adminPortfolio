namespace adminProfolio.Dtos
{
    public class UpdateUserDto
    {
        public string fullname { get; set; } = string.Empty;
        public double phone_number { get; set; } = double.NaN;
        public string Password { get; set; } = string.Empty;
        public string id { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
    }
}
