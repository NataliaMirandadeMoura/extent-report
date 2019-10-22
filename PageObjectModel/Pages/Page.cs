using PageObjectModel.Utils.Selenium;


namespace PageObjectModel.Pages
{
    public abstract class Page
    {
        protected T InstanceOf<T>() where T: BasePage, new()
        {
            var pageClass = new T { Driver = Driver.Browser() };
            return pageClass;
        }
    }
}
