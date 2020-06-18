using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ReactiveUI;

namespace AvaloniaApplication10.ViewModels
{
    public class SecondViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "SecondViewModel";

        public IScreen HostScreen => throw new NotImplementedException();
    }
}
