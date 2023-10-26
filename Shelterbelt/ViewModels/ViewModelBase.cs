using Prism.Mvvm;
using Prism.Regions;
using ReactiveUI;

namespace Shelterbelt.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        public IRegionManager RegionManager;
        public ViewModelBase() { }
        public ViewModelBase(IRegionManager? regionManager)
        {
            if (regionManager != null)
            {
                this.RegionManager = regionManager;
            }
        }

        #region Public Methods
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        /// <summary>Navigation validation checker.</summary>
        /// <remarks>Override for Prism 7.2's IsNavigationTarget.</remarks>
        /// <param name="navigationContext">The navigation context.</param>
        /// <returns><see langword="true"/> if this instance accepts the navigation request; otherwise, <see langword="false"/>.</returns>
        public virtual bool OnNavigatingTo(NavigationContext navigationContext)
        {
            return true;
        }

        #endregion
    }
}