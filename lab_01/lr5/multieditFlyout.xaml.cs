using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lr5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class multieditFlyout : ContentPage
    {
        public ListView ListView;

        public multieditFlyout()
        {
            InitializeComponent();

            BindingContext = new multieditFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class multieditFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<multieditFlyoutMenuItem> MenuItems { get; set; }

            public multieditFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<multieditFlyoutMenuItem>(new[]
                {
                    new multieditFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new multieditFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new multieditFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new multieditFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new multieditFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}