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
using Microsoft.Phone.UserData; 
namespace GroupTextReminder.Views
{
    public partial class GroupPage : PhoneApplicationPage
    {
        public GroupPage()
        {
            InitializeComponent();

            
        }

        private void newGroup_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/NewGroup.xaml", UriKind.Relative)); 
        }
    }
}