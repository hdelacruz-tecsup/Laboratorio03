﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage1 : ContentPage
    {
        public ModalPage1()
        {
            InitializeComponent();
            btnClosePopup.Clicked += async (sender, e) =>
            {
                await Navigation.PopModalAsync();
            };

        }

    }
}