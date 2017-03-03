//Автор игры "Кто под шляпой" - Дмитриенко Ю.Е.

namespace Hat.ViewModels
{
    using Catel.Data;
    using Catel.MVVM;
    using Hat.Models;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Data;
    using System.Windows.Media.Imaging;
    using System.Linq;
    using System.Collections.Generic;
using Catel.Services;
    using System.Threading;

    public class MainWindowViewModel : ViewModelBase
    {
        private static Animal _currentAnimal;
        private readonly IUIVisualizerService _visualService;
        private int result;
        
        public MainWindowViewModel(IUIVisualizerService visualService)
        {
           _visualService = visualService;
           
        }

        public override string Title { get { return "Кто под шляпой?"; } }

        

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            Items = CollectionViewSource.GetDefaultView(Animal.GetAnimals());
            Header = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/6677.png", UriKind.Absolute));
            Hat = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/hat.gif", UriKind.Absolute));
            _currentAnimal = Animal.GetRandomCurrent();
            CurrentDescription = _currentAnimal.Description;
            IsEnabledNext = false;
            IsEnabledStart = true;
            Url = "http://best-buy-now.ru/?name=Ad";
                                 
            
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }

       
        public ICollectionView Items
        {
            get { return GetValue<ICollectionView>(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

       
        public static readonly PropertyData ItemsProperty = RegisterProperty("Items", typeof(ICollectionView), null);

       
        public BitmapImage Header
        {
            get { return GetValue<BitmapImage>(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

       
        public static readonly PropertyData HeaderProperty = RegisterProperty("Header", typeof(BitmapImage), null);

       
        public BitmapImage Hat
        {
            get { return GetValue<BitmapImage>(HatProperty); }
            set { SetValue(HatProperty, value); }
        }

       
        public static readonly PropertyData HatProperty = RegisterProperty("Hat", typeof(BitmapImage), null);

      
        public string MarginHat
        {
            get { return GetValue<string>(MarginHatProperty); }
            set { SetValue(MarginHatProperty, value); }
        }
               
        public static readonly PropertyData MarginHatProperty = RegisterProperty("MarginHat", typeof(string), string.Empty);

        
        public Animal SelectedItem
        {
            get { return GetValue<Animal>(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public static readonly PropertyData SelectedItemProperty = RegisterProperty("SelectedItem", typeof(Animal));



        public string CurrentDescription
        {
            get { return GetValue<string>(CurrentDescriptionProperty); }
            set { SetValue(CurrentDescriptionProperty, value); }
        }

        public static readonly PropertyData CurrentDescriptionProperty = RegisterProperty("CurrentDescription", typeof(string));

        
        public BitmapImage CurrentAnimalImage
        {
            get { return GetValue<BitmapImage>(CurrentAnimalImageProperty); }
            set { SetValue(CurrentAnimalImageProperty, value); }
        }

        
        public static readonly PropertyData CurrentAnimalImageProperty = RegisterProperty("CurrentAnimalImage", typeof(BitmapImage));


        
        public bool IsEnabledNext
        {
            get { return GetValue<bool>(IsEnabledNextProperty); }
            set { SetValue(IsEnabledNextProperty, value); }
        }

       
        public static readonly PropertyData IsEnabledNextProperty = RegisterProperty("IsEnabledNext", typeof(bool));


        public bool IsEnabledStart
        {
            get { return GetValue<bool>(IsEnabledStartProperty); }
            set { SetValue(IsEnabledStartProperty, value); }
        }


        public static readonly PropertyData IsEnabledStartProperty = RegisterProperty("IsEnabledStart", typeof(bool));


        public string Url
        {
            get { return GetValue<string>(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        public static readonly PropertyData UrlProperty = RegisterProperty("Url", typeof(string), string.Empty);


        private Command _showCommand;
  
        public Command ShowCommand 
        {
            get
            {
                return _showCommand ?? ( _showCommand = new Command(() =>
                    {
                        ShowCommandExecute();
                    },
                    () => SelectedItem != null));

            }
        
        }



        private void ShowCommandExecute()
        {
            Header = null;
            MarginHat = "0,-150,0,0";
            CurrentAnimalImage = _currentAnimal.Image;
            Thread.Sleep(500);
            if (SelectedItem.Name == _currentAnimal.Name)
            {
                result++;
                CurrentDescription = "Вы угадали! " + _currentAnimal.Name;
                if (result == 10)
                {
                    _visualService.ShowDialog(new PrizeViewModel());
                    result = 0;
                }
            }
            else
            {
                result--;
                CurrentDescription = "Вы не угадали! " + _currentAnimal.Name;
                
            }
            
            IsEnabledNext = true;
            IsEnabledStart = false;
                        
        }

        
        
        private Command _nextCommand;

        public Command NextCommand
        {
            get
            {
                return _nextCommand ?? (_nextCommand = new Command(() =>
                {
                    NextCommandExecute();
                }));

            }

        }



        private void NextCommandExecute()
        {

            CurrentAnimalImage = null;
            MarginHat = "0,20,0,0";
            IsEnabledStart = true;
            Items = CollectionViewSource.GetDefaultView(Animal.GetAnimals());
            _currentAnimal = Animal.GetRandomCurrent();
            CurrentDescription = _currentAnimal.Description;
            Header = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/6677.png", UriKind.Absolute));
         }


        private Command _clickLinkCommand;

        public Command ClickLinkCommand
        {
            get
            {
                return _clickLinkCommand ?? (_clickLinkCommand = new Command(() =>
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process();
                    p.StartInfo.FileName = Url;
                    p.EnableRaisingEvents = true;
                    p.Start();
                }));

            }

        }



    }
}
