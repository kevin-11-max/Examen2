using AppExamen2.Models;
using AppExamen2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppExamen2.ViewModels
{
    public class MockupsViewModel:BaseViewModel
    {
        //apiservece
        #region Service
        private ApiService apiService;
        #endregion

        #region Attribute
        private long Id;
        private string Title;
        private Uri thumbnailUrl;

        #endregion

        #region Properties
        public long id {
            get { return this.Id; }
            set { SetValue(ref this.Id, value); }
        }
        public string title {
            get { return this.Title; }
            set { SetValue(ref this.Title, value); }
        }
        public Uri ThumbnailUrl {
            get { return this.thumbnailUrl; }
            set { SetValue(ref this.thumbnailUrl, value); }
        }

        #endregion

        #region Constructor
        public MockupsViewModel()
        {
            apiService = new ApiService();
            this.LoadMockups();
        }
        #endregion

        #region methods
        private async void LoadMockups()
        {
            var mockups = await this.apiService.Get<Mockups>(
                "https://jsonplaceholder.typicode.com/",
                "photos/",
                ""
                );
        }


        #endregion

    }
}
