using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ElvisGratton
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            PlayCommand = new Command<string>(filename =>
            {
                var player = AudioPlayerFactory.Create(filename);
                player.Play();
            });

            BindingContext = this;
        }

        public ICommand PlayCommand { private set; get; }

    }
}
