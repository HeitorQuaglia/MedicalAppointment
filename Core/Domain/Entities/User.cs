using Core.Domain.ValueObjects;

namespace Core.Domain.Entities
{
    public abstract class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;

        public Email Email { get; private set; }

        protected User(string firstName, string lastName, string email)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            Email = new Email(email);
        }

        protected void SetFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));
            }
            FirstName = firstName;
        }

        protected void SetLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be null or empty.", nameof(lastName));
            }
            LastName = lastName;
        }
    }
}
