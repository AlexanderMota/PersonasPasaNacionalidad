using Microsoft.Toolkit.Mvvm.ComponentModel;
using PersonaSinCarpetas.service;
using PersonasUCCommand.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasUCCommand.viewmodel
{
    class ListaPersonasVM : ObservableObject
    {
        private List<Persona> personas;
        public List<Persona> Personas
        {
            get => personas;
            set => SetProperty(ref personas, value);
        }
        public ListaPersonasVM()
        {
            this.Personas = Utils.getSamples();
        }
    }
}
