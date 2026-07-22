namespace Store_Online.Core.Interfaces
{
    public interface INavigationService
    {
        void NavigateTo<TViewModel>();

        void GoBack();
    }
}
