﻿

namespace WINDOWS_MIMO_APP_2.ViewModels
{
    using Services.NavigationService;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WINDOWS_MIMO_APP_2.ViewModels.Base;
    using Windows.UI.Xaml.Navigation;
    using System.Windows.Input;
    public class TaskListViewModel : ViewModelBase
    {
        private string message;
        private INavigationService   navService;
        private DelegateCommand goToTaskPageCommand;

        public TaskListViewModel(INavigationService navService)
        {
            this.navService = navService;
            this.goToTaskPageCommand = new DelegateCommand(GoToTaskPageExecute);
            Message = "Welcome to the task List page";
        }
        public ICommand GoToTaskPageCommand
        {
            get { return this.goToTaskPageCommand; }
        }

        

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                RaisePropertyChanged();
            }
        }
        public override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.navService.AppFrame = base.AppFrame;
            Message = (string)e.Parameter;
        }
        public override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }
        public override void GoBackExecute()
        {
            base.GoBackExecute();
        }
        private void GoToTaskPageExecute()
        {
            this.navService.NavigateToTaskPage("TASK");
        }
    }
}
