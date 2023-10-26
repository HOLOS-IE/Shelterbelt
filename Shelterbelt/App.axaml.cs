using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using Shelterbelt.ViewModels;
using Shelterbelt.Views;

namespace Shelterbelt
{
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();              // <-- Required
        }

        protected override AvaloniaObject CreateShell()
        {
            var mainWindow = Container.Resolve<MainWindow>();
            return mainWindow;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Views - Generic
            //containerRegistry.Register<MainWindow>();

            // Views - Region Navigation
            containerRegistry.RegisterForNavigation<ToolbarView, ToolbarViewModel>();
            containerRegistry.RegisterForNavigation<AboutPageView, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<FooterView, FooterViewModel>();
        }
        protected override void OnInitialized()
        {
            // Register Views to the Region it will appear in. Don't register them in the ViewModel.
            var regionManager = Container.Resolve<IRegionManager>();

            // Register views based on user's region
            regionManager.RegisterViewWithRegion(UiRegions.ToolbarRegion, typeof(ToolbarView));
            regionManager.RegisterViewWithRegion(UiRegions.ContentRegion, typeof(AboutPageView));
            regionManager.RegisterViewWithRegion(UiRegions.FooterRegion, typeof(FooterView));
        }
    }
}