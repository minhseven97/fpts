using fpts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace fpts.ViewModels
{
    public class Selected : DataTemplateSelector
    {
        public DataTemplate Top { get; set; }
        public DataTemplate Mid { get; set; }
        public DataTemplate Bot { get; set; }
        public DataTemplate Like { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Me = (MMenu)item;
            string s1 = "head";
            string s2 = "morong";
            
            if (Me.key.Equals(s1))
            {
                return Top;
            }
            else if (Me.key.Equals(s2))
            {
                return Bot;
            }
            else return Mid;
        }
    }
}
