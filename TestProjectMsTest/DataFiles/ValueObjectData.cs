

namespace TestProjectMsTest
{
    public class ValueObjectData
    {
        public ValueObjectData(string firstname, string lastname, string number)
        {
            FirstName = firstname;
            LastName = lastname;
            Number = number;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string Number { get; }

    }
}
