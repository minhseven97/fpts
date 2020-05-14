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
        public ObservableCollection<MMenu> MMenuLikes { get; set; }

        public Command<object> ClickCommand { get; set; }
        //public Command<object> TickClickCommand { get; set; }
        public MasterDetailMainviewMasterViewModel()
        {
            ClickCommand = new Command<object>(click);
            //TickClickCommand = new Command<object>(tickclick);
           
            MMenuLikes = new ObservableCollection<MMenu>();
            MMenus = new ObservableCollection<MMenu>()
            {
                new MMenu(){Ten="Thị trường",key="head"},
                new MMenu()  { Ten="Tổng quan",Hinh="tongquan", key="a",Yeuthich=true , image ="sao.png"},
                new MMenu()  { Ten="Bảng giá",Hinh="banggia", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Tin tức",Hinh="tintuc", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Chỉ số",Hinh="chiso", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="FPT nhận định",Hinh="nhandinh", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Lịch sự kiện",Hinh="lich", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Biểu đồ",Hinh="bieudo", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Giao dịch phát sinh",Hinh="sort",  key="a",Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Giao dịch",key="head" },
                new MMenu()  { Ten="Đặt lệnh",Hinh="law",  key="a",Yeuthich=false,image ="sao.png"},
                
                new MMenu()  { Ten="Báo cáo giao dịch",Hinh="tintuc", key="morong" ,Ten1="Lệnh trong ngày",Ten2="Lịch sử đặt lệnh",Ten3="Lịch sử ứng trước",Yeuthich=false,image ="sao.png"},

                new MMenu()  { Ten="Báo cáo tài sản",Hinh="nhandinh", key="a",Yeuthich=false,image ="sao.png" },
                new MMenu()  { Ten="Bán lô lẻ",Hinh="chiso", key="a",Yeuthich=false ,image ="sao.png"},
                new MMenu()  { Ten="Thực hiện quyền",Hinh="nhandinh",  key="a"  ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Trợ giúp",key="head"},
                new MMenu()  { Ten="Đổi mật khẩu",Hinh="sort", key="a" ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Liên hệ",Hinh="nhandinh",  key="a" ,Yeuthich=false ,image ="sao.png"},
                new MMenu()  { Ten="Góp ý",Hinh="tintuc",  key="a"  ,Yeuthich=false,image ="sao.png"},
                new MMenu()  { Ten="Hướng dẫn sử dụng",Hinh="chiso",  key="a" ,Yeuthich=false,image ="sao.png" }
            };
            
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void click(object obj)
        {
            var mmenu = obj as MMenu;
            if (mmenu.Yeuthich == false)
            {
                mmenu.Yeuthich = true;
                mmenu.image = "saovang.png";
            }
            else{
                mmenu.Yeuthich = false;
                mmenu.image = "sao.png";
            }  
            
        }

        

    }
}
