// There is a class for this in the Microsoft.Phone.UserData library, don't think I even need to define a Contact class

namespace GroupTextReminder
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
            }
        }
    }
}