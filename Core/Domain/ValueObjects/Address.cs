namespace Core.Domain.ValueObjects
{
    public class Address(
        string street,
        string city,
        string state,
        string zipCode,
        string neighborhood = "",
        string complement = "",
        string number = "")
    {
        public string Street { get; private set; } = street;
        public string City { get; private set; } = city;
        public string State { get; private set; } = state;
        public string ZipCode { get; private set; } = zipCode;
        public string Neighborhood { get; private set; } = neighborhood;
        public string Complement { get; private set; } = complement;
        public string Number { get; private set; } = number;
    }
}
