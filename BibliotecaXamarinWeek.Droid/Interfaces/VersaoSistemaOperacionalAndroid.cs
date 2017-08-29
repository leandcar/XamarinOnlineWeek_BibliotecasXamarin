using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BibliotecaXamarinWeek.Droid.Interfaces;
using BibliotecaXamarinWeek.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(VersaoSistemaOperacionalAndroid))]
namespace BibliotecaXamarinWeek.Droid.Interfaces
{
    public class VersaoSistemaOperacionalAndroid : IVersaoSistemaOperacional
    {
        public string ObterVersaoSO()
        {
            return Android.OS.Build.VERSION.Sdk;
        }
    }
}