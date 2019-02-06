using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PanPlayground
{

    public class User
    {
        public string Name { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Users.ItemsSource = new List<User>()
            {
                new User() {Name = "123"}
            };
        }
    }
}
