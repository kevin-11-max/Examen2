
namespace AppExamen2.Infrastructure
{
    using AppExamen2.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
