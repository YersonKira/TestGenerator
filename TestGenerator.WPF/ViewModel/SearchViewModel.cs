using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestGenerator.Data.Database.Entitites;
using TestGenerator.Data.Repositories;

namespace TestGenerator.WPF.ViewModel
{
    public class SearchViewModel: ViewModelCommon
    {
        #region Repositories
        public IUserRepository UserRepository { get; set; }
        #endregion

        #region Properties
        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get { return users; }
            set { users = value; RaisePropertyChanged("Users"); }
        }
        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; RaisePropertyChanged<string>("SearchText"); }
        }

        #endregion

        #region Commands
        public ICommand GetAllCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ChangeCommand { get; set; }
        #endregion

        #region Constructor
        public SearchViewModel(IUserRepository repository)
        {
            this.Title = "Search";
            this.UserRepository = repository;
            this.GetAllCommand = new RelayCommand(GetAll);
            this.EditCommand = new RelayCommand<User>(Edit);
            this.DeleteCommand = new RelayCommand<User>(Delete);
            this.ChangeCommand = new RelayCommand<TextChangedEventArgs>(Search);
        }
        #endregion

        #region Methods
        public async void Search(TextChangedEventArgs args)
        {
            var result = await this.UserRepository.Search(this.SearchText);
            this.Users = new ObservableCollection<User>(result);
        }
        public void Edit(User user)
        {
            MessageBox.Show(string.Format("Edit to {0}", user.Names));
        }
        public void Delete(User user)
        {
            MessageBox.Show(string.Format("Delete to {0}", user.Names));
        }
        public async void GetAll()
        {
            var result = await this.UserRepository.GetAll();
            this.Users = new ObservableCollection<User>(result);
        }
        #endregion
        
    }
}
