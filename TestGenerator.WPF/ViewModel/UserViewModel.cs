using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGenerator.Data.Repositories;

namespace TestGenerator.WPF.ViewModel
{
    public class UserViewModel: ViewModelCommon
    {
        public IUserRepository UserRepository { get; set; }
        public UserViewModel(IUserRepository repository)
        {
            this.Title = "User";
            this.UserRepository = repository;
        }

    }
}
