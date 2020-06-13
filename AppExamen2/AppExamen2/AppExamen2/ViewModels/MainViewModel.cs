using System;
using System.Collections.Generic;
using System.Text;

namespace AppExamen2.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public MockupsViewModel Mockupies { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Mockupies = new MockupsViewModel();
        }
        #endregion
    }
}
