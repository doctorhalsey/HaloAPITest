﻿using HaloEzAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HaloAPITest
{
    /// <summary>
    /// Interaction logic for ListagemInimigos.xaml
    /// </summary>
    public partial class ListagemInimigos : UserControl
    {
        HaloAPIService haloAPI;

        public ListagemInimigos(HaloAPIService _haloAPI)
        {
            InitializeComponent();

            haloAPI = _haloAPI;

            CarregarInimigos();
        }

        async void CarregarInimigos()
        {
            var inimigos = await haloAPI.GetEnemies();
            ListaInimigos.ItemsSource = inimigos;
        }

        private void inimigohalo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
