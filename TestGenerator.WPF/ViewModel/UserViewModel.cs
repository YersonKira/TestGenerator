using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using TestGenerator.Data.Database.Entitites;
using TestGenerator.Data.Repositories;
using TestGenerator.WPF.ViewModel.utils;

namespace TestGenerator.WPF.ViewModel
{
    public class UserViewModel: ViewModelCommon
    {
        public IUserRepository UserRepository { get; set; }

        #region Properties
        private User user;
        public User User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged<User>("User"); }
        }
        private bool isSaveButtonEnabled = true;
        public bool IsSaveButtonEnabled
        {
            get { return isSaveButtonEnabled; }
            set { isSaveButtonEnabled = value; RaisePropertyChanged("IsSaveButtonEnabled"); }
        }
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; RaisePropertyChanged("ImagePath"); }
        }
        private Visibility isProgressBarEnabled = Visibility.Hidden;
        public Visibility IsProgressBarEnabled
        {
            get { return isProgressBarEnabled; }
            set { isProgressBarEnabled = value; RaisePropertyChanged("IsProgressBarEnabled"); }
        }
        #endregion
        #region Commands
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand SelectImageCommand { get; set; }
        #endregion

        public UserViewModel(IUserRepository repository)
        {
            this.Title = "User";
            this.UserRepository = repository;
            this.User = new User();
            this.SaveCommand = new RelayCommand(SaveUser);
            this.CancelCommand = new RelayCommand(CancelUser);
            this.SelectImageCommand = new RelayCommand(SelectImage);
        }
        public async void SaveUser()
        {
            this.IsSaveButtonEnabled = false;
            this.IsProgressBarEnabled = Visibility.Visible;
            this.User.Image = await Utils.ImageToByteArray(this.ImagePath);
            await this.UserRepository.Add(this.User);
            this.IsSaveButtonEnabled = true;
            this.IsProgressBarEnabled = Visibility.Hidden;
        }
        public void SelectImage()
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".png";
            dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                this.ImagePath = dialog.FileName;
            }
        }
        public void CancelUser()
        {
            MessageBox.Show("Cancel");
        }
    }
}
