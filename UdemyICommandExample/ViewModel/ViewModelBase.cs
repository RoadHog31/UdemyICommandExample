using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UdemyICommandExample.ViewModel.Commands;

namespace UdemyICommandExample.ViewModel
{
    public class ViewModelBase
    {
        public HelloCommand HelloCommand { get; set; }

        //Class Constructor
        public ViewModelBase()
        {
            HelloCommand = new HelloCommand(this);
        }

        public void SayHello()
        {
            MessageBox.Show("Hello from Commands!");
        }
    }
}
