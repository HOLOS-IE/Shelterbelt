using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelterbelt.ViewModels
{
    public class ToolbarViewModel : ViewModelBase
    {
        public ToolbarViewModel() { }
        public ToolbarViewModel(IRegionManager regionManager) : base(regionManager)
        {
        }
    }
}
