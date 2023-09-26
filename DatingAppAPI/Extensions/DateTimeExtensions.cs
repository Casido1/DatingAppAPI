namespace DatingAppAPI.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.UtcNow;

            var age = today.Year - dob.Year;

            if (today.Month < dob.Month) age--;
            else if (today.Month == dob.Month && today.Day < dob.Day) age--;

            return age;
        }
    }
}
