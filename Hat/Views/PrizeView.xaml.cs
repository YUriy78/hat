namespace Hat.Views
{
    using Catel.Windows;
    using ViewModels;

    public partial class PrizeView
    {
        public PrizeView()
            : this(null) { }

        public PrizeView(PrizeViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
