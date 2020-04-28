using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using OutilEnquete.Contracts.Services.Data;
using OutilEnquete.Contracts.Services.General;
using OutilEnquete.Extensions;
using OutilEnquete.Models;
using OutilEnquete.ViewModels.Base;
using Xamarin.Forms;

namespace OutilEnquete.ViewModels
{
    public class PieCatalogViewModel : ViewModelBase
    {
        private readonly ICatalogDataService _catalogDataService;

        private ObservableCollection<Pie> _pies;

        public PieCatalogViewModel(IConnectionService connectionService,
            INavigationService navigationService, IDialogService dialogService,
            ICatalogDataService catalogDataService)
            : base(connectionService, navigationService, dialogService)
        {
            _catalogDataService = catalogDataService;
        }

        public ICommand PieTappedCommand => new Command<Pie>(OnPieTapped);

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged();
            }
        }
 
        private void OnPieTapped(Pie selectedPie)
        {
            _navigationService.NavigateToAsync<PieDetailViewModel>(selectedPie);
        }

        public override async Task InitializeAsync(object data)
        {
            IsBusy = true;

            Pies = (await _catalogDataService.GetAllPiesAsync()).ToObservableCollection();

            IsBusy = false;
        }
    }
}
