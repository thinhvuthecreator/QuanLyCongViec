﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PhanMemQuanLyCongViec.ViewModel
{
    public class LoaiHinhView_ViewModel : BaseViewModel
    {
        #region commands
        public RelayCommand<WrapPanel> themLoaiHinhCommand { get; set; }
        #endregion
        public LoaiHinhView_ViewModel()
        {
            themLoaiHinhCommand = new RelayCommand<WrapPanel>((p) => { return true; }, (p) =>
            {
                
                (p as WrapPanel).Children.Add(themLoaiHinh("Hình thờ"));

            });
        }

        Button themLoaiHinh(string tenLoaiHinh)
        {
            Button loaiHinhBtn = new Button();
            loaiHinhBtn.Width = 180;
            loaiHinhBtn.Height = 150;
            Thickness margin = loaiHinhBtn.Margin;
            margin.Left = 20;
            margin.Right = 20;
            margin.Top = 20;
            margin.Bottom = 20;
            loaiHinhBtn.Margin = margin;
            var bc = new BrushConverter();
            loaiHinhBtn.Background = (Brush)bc.ConvertFrom("#FF3E4E5F");
            loaiHinhBtn.Content = tenLoaiHinh;
            return loaiHinhBtn;

        }
    }
}
