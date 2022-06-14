using Medidas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Xamarin.Forms;

namespace Medidas.ViewModels
{
    public class VMHombre : INotifyPropertyChanged
    {
        public VMHombre()
        {
            CrearHombre = new Command(
                    () => {

                        H1 = H1;

                        BinaryFormatter formatter = new BinaryFormatter();
                        string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Hombre.aut");
                        Stream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(archivo, H1);
                        archivo.Close();

                    }
                );
            Abrir = new Command(() => {


                BinaryFormatter formatter = new BinaryFormatter();
                string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Hombre.aut");
                Stream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
                H1 = (VMHombre)formatter.Deserialize(archivo);
                archivo.Close();


            });
        }

        VMHombre h1 = new VMHombre();
        public VMHombre H1
        {
            get => h1;
            set
            {

                h1 = value;
                var args = new PropertyChangedEventArgs(nameof(H1));
                PropertyChanged?.Invoke(this, args);

            }
        }

        public Command CrearHombre { get; }
        public Command Abrir { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
