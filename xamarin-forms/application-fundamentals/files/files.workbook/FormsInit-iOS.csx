#r "Xamarin.Forms.Core"
#r "Xamarin.Forms.Xaml"
#r "Xamarin.Forms.Platform"
#r "Xamarin.Forms.Platform.iOS"

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

class App : Application
{
    public App()
    {
        MainPage = new ContentPage();
    }
}

Xamarin.Forms.Forms.Init();
App app = new App();
KeyWindow.RootViewController = app.MainPage.CreateViewController();

ContentPage page = app.MainPage as ContentPage;

StackLayout stackLayout = new StackLayout { Margin = new Thickness(20) };
page.Content = stackLayout;
