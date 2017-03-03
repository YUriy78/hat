//Автор игры "Кто под шляпой" - Дмитриенко Ю.Е.

namespace Hat.ViewModels
{
    using Catel.Data;
    using Catel.MVVM;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public class PrizeViewModel : ViewModelBase
    {
        public PrizeViewModel()
        {
        }

        public override string Title { get { return "Призовое окно"; } }
          
        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            ControlVideo = "Play";         
        }


        protected override async Task CloseAsync()
        {
            await base.CloseAsync();
        }

       
        public string ControlVideo
        {
            get { return GetValue<string>(ControlVideoProperty); }
            set { SetValue(ControlVideoProperty, value); }
        }

        
        public static readonly PropertyData ControlVideoProperty = RegisterProperty("ControlVideo", typeof(string));
        
        private Command _playCommand;

        public Command PlayCommand
        {

            get
            {
                return _playCommand ?? (_playCommand = new Command(() =>
                {
                   ControlVideo = "Play";
                }, () => ControlVideo != "Play"));

            }

        }
     
        
        private Command _stopCommand;
     
        public Command StopCommand {

            get
            {
                return _stopCommand ?? (_stopCommand = new Command(() =>
                    {

                        ControlVideo = "Stop";
                    },
                    () => ControlVideo != "Stop"));                 
                    

            }
        
        }
                       
        
        private Command _pauseCommand;

        public Command PauseCommand
        {

            get
            {
                return _pauseCommand ?? (_pauseCommand = new Command(() =>
                {

                    ControlVideo = "Pause";
                },
                () => ControlVideo != "Pause"));

            }
         }
 
        
    }
}
