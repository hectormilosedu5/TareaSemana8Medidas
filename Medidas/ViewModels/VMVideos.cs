using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Medidas.ViewModels
{
    public class ViewModelVideos : INotifyPropertyChanged
    {
        public ViewModelVideos()
        {

            CambiarVideoTriangulo = new Command(() => {

                VideoActual = videoCardio;

            });

            CambiarVideoCirculos = new Command(() => {

                VideoActual = videoMovingCardio;

            });


            CambiarVideoCuadros = new Command(() => {

                VideoActual = videoZumba;

            });

        }

        private string videoCardio = "https://www.youtube.com/watch?v=L_W4F6_c2Jg";
        private string videoMovingCardio = "https://www.youtube.com/watch?v=Djcl1wikmLw";
        private string videoZumba = "https://www.youtube.com/watch?v=GSyThDkgfFI";


        string videoActual = "https://www.youtube.com/watch?v=5MPCU7V4Akk";

        public event PropertyChangedEventHandler PropertyChanged;
        public String VideoActual
        {
            get => videoActual;
            set
            {
                videoActual = value;
                var args = new PropertyChangedEventArgs(nameof(VideoActual));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command CambiarVideoTriangulo { get; }
        public Command CambiarVideoCirculos { get; }
        public Command CambiarVideoCuadros { get; }


    }
}
