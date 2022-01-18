using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonaSinCarpetas.requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class AgregaNacionalidadVM : ObservableObject
    {
        private String nac;
        public String Nacionalidad
        {
            get => nac;
            set => SetProperty(ref nac, value);
        }
        public RelayCommand EnviaNacionalidadCommand { get; }


        public AgregaNacionalidadVM()
        {
            this.EnviaNacionalidadCommand = new RelayCommand(EnviaNavionalidad);
        }

        private void EnviaNavionalidad()
        {
            throw new NotImplementedException();
        }
        /*
EnviaNacionalidadCommand


private Navegacion nav;
public RelayCommand UCListaPersonasCommand { get; }
public RelayCommand UCNuevaPersonaCommand { get; }

public MainWindowVM()
{
   this.nav = new Navegacion();
   this.UCListaPersonasCommand = new RelayCommand(MuestraUCListaPersonas);
   this.UCNuevaPersonaCommand = new RelayCommand(MuestraUCNuevaPersona);
}

private void MuestraUCListaPersonas() => this.UsControl = nav.MuestraListaPersonasUC();

private void MuestraUCNuevaPersona() => this.UsControl = nav.MuestraNuevaPersonaUC();

*/
        /*
         

        private void AgregaNacionalidad_Click(object sender, RoutedEventArgs e)
        {
            vm.Nacionalidad = textNacionalidad.Text;
            this.DialogResult = true;
        }
         */
        /*botonAccion
         
            WeakReferenceMessenger.Default.Send(new PasaTextoNacionalidad(Nacionalidad));
         
         */

    }
}
