using GalaSoft.MvvmLight;
using TestGenerator.Data.Repositories;

namespace TestGenerator.WPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelCommon currentViewModel;
        public ViewModelCommon CurrentViewModel
        {
            get { return currentViewModel; }
            set {
                if (currentViewModel == value) return;
                currentViewModel = value;
                RaisePropertyChanged<ViewModelCommon>("CurrentViewModel");
            }
        }

        readonly HomeViewModel homeViewModel = new HomeViewModel();
        readonly UserViewModel userViewModel = new UserViewModel(new UserRepository());
        readonly SearchViewModel searchViewModel = new SearchViewModel(new UserRepository());

        public MainViewModel()
        {
            CurrentViewModel = searchViewModel;
        }
    }
}