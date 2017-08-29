using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using BibliotecaXamarinWeek.iOS.Interfaces;
using BibliotecaXamarinWeek.Interfaces;


[assembly: Xamarin.Forms.Dependency(typeof(VersaoSistemaOperacionaliOS))]
namespace BibliotecaXamarinWeek.iOS.Interfaces
{
    public class VersaoSistemaOperacionaliOS : IVersaoSistemaOperacional
    {
        public string ObterVersaoSO()
        {
            return NSProcessInfo.ProcessInfo.OperatingSystemVersionString;
        }
    }
}