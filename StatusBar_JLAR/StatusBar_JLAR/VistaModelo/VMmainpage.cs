﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StatusBar_JLAR.VistaModelo
{
    internal class VMmainpage
    {
        public VMmainpage()
        {

        }
        public void Ocultar()
        {
            DependencyService.Get<VMstatusbar>().OcultarStatusBar();
        }
        public void Mostrar()
        {
            DependencyService.Get<VMstatusbar>().MostrarStatusBar();
        }
        public void Traslucido()
        {
            DependencyService.Get<VMstatusbar>().Traslucido();
        }
        public void Transparente()
        {
            DependencyService.Get<VMstatusbar>().Transparente();
        }
        public void CambiarColor()
        {
            DependencyService.Get<VMstatusbar>().CambiarColor();
        }
        public ICommand OcultarCommand => new Command(Ocultar);
        public ICommand MostrarCommand => new Command(Mostrar);
        public ICommand TraslucidoCommand => new Command(Traslucido);
        public ICommand TrasparenteCommand => new Command(Transparente);
        public ICommand CambiarColorCommand => new Command(CambiarColor);
    }
}
