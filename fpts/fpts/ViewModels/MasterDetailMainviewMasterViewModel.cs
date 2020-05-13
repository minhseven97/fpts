using fpts.Models;
using fpts.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpts.ViewModels
{
    public class MasterDetailMainviewMasterViewModel :  INotifyPropertyChanged
    {
        public ObservableCollection<MMenu> MMenus { get; set; }
        
        private bool _isLiked;
        Command HeartTapCommand { get; set; }
        public MasterDetailMainviewMasterViewModel()
        {
            HeartTapCommand= new Command(() => { IsLiked = !IsLiked; });
           
            MMenus = new ObservableCollection<MMenu>()
            {
                new MMenu(){Ten="Thị trường",key="head"},
                new MMenu()  { Ten="Tổng quan",Hinh="tongquan",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Bảng giá",Hinh="banggia",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Tin tức",Hinh="tintuc",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Chỉ số",Hinh="chiso",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="FPT nhận định",Hinh="nhandinh",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Lịch sự kiện",Hinh="lich",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Biểu đồ",Hinh="bieudo",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Giao dịch phát sinh",Hinh="sort",Ngoisao1="sao",Yeuthich=false  ,key="a"},
                new MMenu()  { Ten="Giao dịch",key="head" },
                new MMenu()  { Ten="Đặt lệnh",Hinh="law",Ngoisao1="sao",Yeuthich=false,key="a"},
                
                new MMenu()  { Ten="Báo cáo giao dịch",Hinh="tintuc",Ngoisao1="sao",Yeuthich=false ,key="morong" ,Ten1="Lệnh trong ngày",Ten2="Lịch sử đặt lệnh",Ten3="Lịch sử ứng trước"},
                //new MMenu()  { Ten="Lệnh trong ngày",key="morong"},
                //new MMenu()  { Ten="Lịch sử đặt lệnh",key="morong"},
                //new MMenu()  { Ten="Lịch sử ứng trước" ,key="morong"},
                new MMenu()  { Ten="Báo cáo tài sản",Hinh="nhandinh",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Bán lô lẻ",Hinh="chiso",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Thực hiện quyền",Hinh="nhandinh",Ngoisao1="sao",Yeuthich=false,key="a"  },
                new MMenu()  { Ten="Trợ giúp",key="head"},
                new MMenu()  { Ten="Đổi mật khẩu",Hinh="sort",Ngoisao1="sao",Yeuthich=false ,key="a" },
                new MMenu()  { Ten="Liên hệ",Hinh="nhandinh",Ngoisao1="sao",Yeuthich=false,key="a"  },
                new MMenu()  { Ten="Góp ý",Hinh="tintuc",Ngoisao1="sao",Yeuthich=false,key="a"  },
                new MMenu()  { Ten="Hướng dẫn sử dụng",Hinh="chiso",Ngoisao1="sao",Yeuthich=false,key="a"  }
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public async void tapped()
        
        public bool IsLiked
        {
            get { return _isLiked; }
            set
            {
                _isLiked = value;
                OnPropertyChanged("IsLiked");
            }
        }

    }
}
