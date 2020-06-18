using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace AvaloniaApplication10.ViewModels
{
    public class FirstViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "FirstViewModel";

        public IScreen HostScreen => throw new NotImplementedException();
    }
}
