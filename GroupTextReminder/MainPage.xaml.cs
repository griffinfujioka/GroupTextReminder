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

namespace GroupTextReminder
{
    public partial class MainPage : PhoneApplicationPage
    {

        AddressChooserTask addressTask;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            addressTask = new AddressChooserTask();
            addressTask.Completed += new EventHandler<AddressResult>(addressTask_Completed);
        }

        void addressTask_Completed(object sender, AddressResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //this.displayName = e.DisplayName;
                //this.tbName.Text = "Name: " + e.DisplayName;
                //this.tbAddress.Text = "Address: " + e.Address;
            }
        }


        #region View group page button click 
        private void viewGroupsButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/GroupPage.xaml", UriKind.Relative));
        }
        #endregion 

        private void newReminderBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewGroupsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}