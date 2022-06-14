using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Xamarin.Forms;

namespace Medidas.ViewModels
{
    class VMMujer : INotifyPropertyChanged
    {
        public VMMujer()
        {
            CrearMujer = new Command(
                    () => {

                        M1 = M1;

                        BinaryFormatter formatter = new BinaryFormatter();
                        string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Hombre.aut");
                        Stream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(archivo, M1);
                        archivo.Close();

                    }
                );
            Abrir = new Command(() => {


                BinaryFormatter formatter = new BinaryFormatter();
                string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Hombre.aut");
                Stream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
                M1 = (VMMujer)formatter.Deserialize(archivo);
                archivo.Close();


            });
        }
        VMMujer m1 = new VMMujer();
        public VMMujer M1
        {
            get => m1;
            set
            {

                m1 = value;
                var args = new PropertyChangedEventArgs(nameof(M1));
                PropertyChanged?.Invoke(this, args);

            }
        }

        public Command CrearMujer { get; }
        public Command Abrir { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
