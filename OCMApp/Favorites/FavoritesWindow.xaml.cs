﻿using MahApps.Metro.Controls;
using Serilog;
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
using System.Windows.Shapes;

namespace OCMApp.Favorites
{
    /// <summary>
    /// Interaction logic for FavoritesWindow.xaml
    /// </summary>
    public partial class FavoritesWindow : MetroWindow
    {
        public FavoritesWindow()
        {
            InitializeComponent();
            OnRefresh();
        }

        private void OnRefresh()
        {
            this.Dispatcher.Invoke(() =>
            {
                var result = Internal.Global.Instance.FavoriteItems;
                FavoritesWrapper.Children.Clear();
                foreach (FavoriteItemViewModel item in result)
                {
                    FavoritesWrapper.Children.Add(
                    new FavoriteItem
                    {
                        DataContext = item
                    }
                    );
                }
            });
        }

        public void Refresh()
        {
            OnRefresh();
        }
    }
}
