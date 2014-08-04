using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        #endregion

        #region Commands
        public ICommand GetAllCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        #endregion

        public SearchViewModel(IUserRepository repository)
        {
            this.Title = "Search";
            this.UserRepository = repository;
            this.GetAllCommand = new RelayCommand(GetAll);
            this.EditCommand = new RelayCommand<User>(Edit);
            this.DeleteCommand = new RelayCommand<User>(Delete);
            this.GetAll();
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
            var result = (await this.UserRepository.GetAll()).ToList();
            result.Add(new User() { UserCI = "123456", Names = "Carlos", FirstName = "Mamani", LastName = "Mamani" });
            result.Add(new User() { UserCI = "789456", Names = "Maria", FirstName = "Mamani", LastName = "Mamani" });
            this.Users = new ObservableCollection<User>(result);
        }
    }
}
