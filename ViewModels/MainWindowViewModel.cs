using System.Reflection;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;

namespace AvaloniaApplication10.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IScreen
    {
        private bool _showMaster;
        private int _delay = 1;

        // The Router associated with this Screen.
        // Required by the IScreen interface.
        public RoutingState Router { get; } = new RoutingState();

        public MainWindowViewModel() =>
            // Router uses Splat.Locator to resolve views for view models, so we need to register our views; i.e. any control of type ReactiveUserControl<T>
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

        public void Toggle()
        {
            ShowMaster = !ShowMaster;
            IRoutableViewModel viewModel = ShowMaster ? (IRoutableViewModel)new FirstViewModel() : new SecondViewModel();
            Router.NavigateAndReset.Execute(viewModel);
            Task.Delay(_delay).Wait();
        }

        public void Delay() => _delay = _delay == 1 ? 500 : 1;

        public bool ShowMaster { get => _showMaster; set => this.RaiseAndSetIfChanged(ref _showMaster, value); }
    }
}
