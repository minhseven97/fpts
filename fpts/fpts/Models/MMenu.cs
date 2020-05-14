using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace fpts.Models
{
    public class MMenu : BindableBase
    {
        private bool _yeuthich;
        private string _image;

        public string Ten { get; set; }
        public string Ten1 { get; set; }
        public string Ten2 { get; set; }
        public string Ten3 { get; set; }
        public string Hinh { get; set; }
        public bool Yeuthich { get => _yeuthich; set => SetProperty(ref _yeuthich, value); }
        public string key { get; set; }
        public string image { get => _image; set =>SetProperty(ref _image, value); }
        
    }
}
