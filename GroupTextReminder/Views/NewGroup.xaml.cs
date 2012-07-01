using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.UserData; 

namespace GroupTextReminder.Views
{
    public partial class NewGroup : PhoneApplicationPage
    {
        AddressChooserTask addressTask;
        PhoneNumberChooserTask numberTask;
        String contactName = ""; 
        string contactPhoneNumber = "";
        Group newGroup = new Group(); 
        public NewGroup()
        {
            InitializeComponent();
            numberTask = new PhoneNumberChooserTask(); 
            numberTask.Completed += new EventHandler<PhoneNumberResult>(numberTask_Completed);
            addressTask = new AddressChooserTask();
            addressTask.Completed += new EventHandler<AddressResult>(addressTask_Completed);
            
            
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            numberTask.Show(); 
        }

        #region Address task completed 
        void addressTask_Completed(object sender, AddressResult e)
        {
            
            if (e.TaskResult == TaskResult.OK)
            {
                
                
            }
        }
        #endregion 

        void numberTask_Completed(object sender, PhoneNumberResult e)
        {
            contactPhoneNumber = e.PhoneNumber;
            contactName = e.DisplayName;

            var newContact = new Contact { Name = contactName, PhoneNumber = contactPhoneNumber };

            newGroup.People.Add(newContact);        // Add contact to the group

            membersListBox.ItemsSource = newGroup.People; 
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (groupNameTxtBox.Text == "")         // No group name was entered 
                MessageBox.Show("Please give your new group a name", "", MessageBoxButton.OK);
            else
                newGroup.GroupName = groupNameTxtBox.Text; 


        }

        private void txtGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            SmsComposeTask smsTask = new SmsComposeTask();
            String message = "Here is the message to be sent out";

            foreach (var contact in newGroup.People)
                smsTask.To += contact.PhoneNumber + ";";

            smsTask.Body = message;

            smsTask.Show(); 
        }
    }
}