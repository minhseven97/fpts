using fpts.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace fpts.ViewModels
{
    public class BangGiaListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<BangGia> BangGias { get; set; }
        public BangGiaListViewModel()
        {
            BangGias = new ObservableCollection<BangGia>()
            {
                new BangGia(){ma="VIC",gia=95,thaydoi1=-1.01,thaydoi2=0.01,kl=0,tien=0},
                new BangGia(){ma="FTS",gia=292,thaydoi1=0.2,thaydoi2=0.13,kl=0,tien=42.12},
                new BangGia(){ma="VN30",gia=343,thaydoi1=-0.25,thaydoi2=-0.26,kl=0,tien=2.22},
                new BangGia(){ma="FPT",gia=112,thaydoi1=-0.42,thaydoi2=0.21,kl=0,tien=10.2},
                new BangGia(){ma="GAS",gia=54,thaydoi1=1.1,thaydoi2=0.54,kl=0,tien=23.4},
                new BangGia(){ma="DPM",gia=12,thaydoi1=-0,thaydoi2=0.1,kl=0,tien=22.4},
                new BangGia(){ma="HVN",gia=36,thaydoi1=-0.51,thaydoi2=0.6,kl=0,tien=10.1},
                new BangGia(){ma="HNX",gia=23,thaydoi1=-0.07,thaydoi2=0.21,kl=0,tien=10.2},
                new BangGia(){ma="UPCOM",gia=23,thaydoi1=0,thaydoi2=0.5,kl=0,tien=10.1},
                new BangGia(){ma="VTC",gia=657,thaydoi1=-0.24,thaydoi2=0.12,kl=0,tien=10.1}
            };
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;
            
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
