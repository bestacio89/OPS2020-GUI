﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using OutilEnquete.Annotations;
using OutilEnquete.Contracts.Services.General;

namespace OutilEnquete.ViewModels.Base
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        protected readonly IConnectionService _connectionService;
        protected readonly INavigationService _navigationService;
        protected readonly IDialogService _dialogService;

        public ViewModelBase(IConnectionService connectionService, INavigationService navigationService, 
            IDialogService dialogService)
        {
            _connectionService = connectionService;
            _navigationService = navigationService;
            _dialogService = dialogService;
        }

        private bool _isBusy;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value; 
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Task InitializeAsync(object data)
        {
            return Task.FromResult(false);
        }
    }
}
