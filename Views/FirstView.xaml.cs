using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaApplication10.ViewModels;

namespace AvaloniaApplication10.Views
{
    public class FirstView : ReactiveUserControl<FirstViewModel>
    {
        public FirstView() => AvaloniaXamlLoader.Load(this);
    }
}
