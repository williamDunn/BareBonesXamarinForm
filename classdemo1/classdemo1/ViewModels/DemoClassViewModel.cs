using classdemo1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace classdemo1.ViewModels
{
    public class DemoClassViewModel: BaseViewModel
    {
        public DemoClass ClassInfo { get; set; }
        public DemoClassViewModel()
        {
            ClassInfo = new DemoClass();
            ClassInfo.Name = "CPSC 475-3";
            ClassInfo.Description = "Capstone course with skyline";
            Title = "xamarin form - will";
        }
    }
}
