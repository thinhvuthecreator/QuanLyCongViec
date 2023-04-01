﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PhanMemQuanLyCongViec.View;

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
                ThemLoaiHinhView windowThem = new ThemLoaiHinhView();
                windowThem.ShowDialog();
                bool isClick = (windowThem.DataContext as ThemLoaiHinh_ViewModel).isClick;
                if (isClick)
                {
                    (p as WrapPanel).Children.Add(themLoaiHinh((windowThem.DataContext as ThemLoaiHinh_ViewModel).tenLoaiHinh));
                }
                else
                {

                }

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
            loaiHinhBtn.MouseEnter += LoaiHinhBtn_MouseEnter;
            loaiHinhBtn.MouseLeave += LoaiHinhBtn_MouseLeave;
            return loaiHinhBtn;

        }

        #region events
        private void LoaiHinhBtn_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button thisBtn = sender as Button;
            var bc = new BrushConverter();
            thisBtn.Background = (Brush)bc.ConvertFrom("#FF3E4E5F");
            thisBtn.Foreground = (Brush)bc.ConvertFrom("White");
        }
        private void LoaiHinhBtn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button thisBtn = sender as Button;
            var bc = new BrushConverter();
            thisBtn.Background = (Brush)bc.ConvertFrom("#FFE3FFFE");
            thisBtn.Foreground = (Brush)bc.ConvertFrom("#FF080808");
        }
        #endregion

    }
}
