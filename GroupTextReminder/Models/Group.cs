using Microsoft.Phone.Tasks; 
using System.Collections.Generic;
using System.Collections.ObjectModel; 

namespace GroupTextReminder
{
    public class Group
    {
        public ObservableCollection<Contact> _people = new ObservableCollection<Contact>();
        string _groupName = ""; 

        public string GroupName
        {
            get { return _groupName; }
            set
            {
                _groupName = value;
            } 
        }

        public ObservableCollection<Contact> People
        {
            get { return _people; }
            set
            {
                _people = value; 
            }
        } 
    }
}