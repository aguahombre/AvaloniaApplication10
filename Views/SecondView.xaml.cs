using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaApplication10.ViewModels;

namespace AvaloniaApplication10.Views
{
    public class SecondView : ReactiveUserControl<SecondViewModel>
    {
        public SecondView() => AvaloniaXamlLoader.Load(this);
    }
}
