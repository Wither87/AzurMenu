using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Azure.VM
{
    class MainVM
    {
        Page MainPage;
        Page DockPage;

        Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (_currentPage == value)
                    return;
                _currentPage = value;
            }
        }

        public MainVM()
        {
            MainPage = new Pages.MainPage();
            DockPage = new Pages.DockPage();

            CurrentPage = MainPage;
        }

        public ICommand bMainPage_Click
        {
            get
            {
                return new RelayCommand(() => ShowPage(MainPage));
            }
        }
        public ICommand bDockPage_Click
        {
            get
            {
                return new RelayCommand(() => ShowPage(DockPage));
            }
        }

        private void ShowPage(Page page)
        {
            CurrentPage = page;
        }
    }
}
