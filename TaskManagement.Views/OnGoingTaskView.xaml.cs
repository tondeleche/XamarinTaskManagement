﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskManagement.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnGoingTaskView : ContentPage
    {
        public OnGoingTaskView()
        {
            InitializeComponent();
        }
    }
}