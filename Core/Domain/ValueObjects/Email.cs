namespace Core.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; private set; } = string.Empty;

        public Email(string value) {
            this.SetValue(value);
        }

        public void SetValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Email cannot be null or empty.", nameof(value));
            }
         
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("Invalid email format.", nameof(value));
            }
            Value = value;
        }
    }
}
