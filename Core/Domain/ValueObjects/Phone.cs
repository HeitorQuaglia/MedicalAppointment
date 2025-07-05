using System.Text.RegularExpressions;

namespace Core.Domain.ValueObjects
{
    public class Phone
    {
        public string Value { get; private set; } = string.Empty;
        
        public Phone(string value)
        {
            SetValue(value);
        }

        public void SetValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Phone number cannot be null or empty.", nameof(value));
            }
            if (Regex.IsMatch(value, @"^\+?[1-9]\d{1,14}$"))
            {
                throw new ArgumentException("Invalid phone number format.", nameof(value));
            }
            this.Value = value;
        }
    }
}
