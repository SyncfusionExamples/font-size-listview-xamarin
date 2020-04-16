# How to set the font size for Xamarin.Forms ListView (SfListView)

You can set the [FontSize](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.label.fontsize?view=xamarin-forms) for all the elements inside Xamarin.Forms [SfListView](https://help.syncfusion.com/xamarin/listview/overview?) with size in physical devices of the same size by defining the font size based on the width and height of the page. 

You can also refer the following article.

https://www.syncfusion.com/kb/11403/how-to-set-the-font-size-for-xamarin-forms-listview-sflistview

**C#**

Triggered [SizeChanged](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.sizechanged?view=xamarin-forms) event of the [ContentPage](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.contentpage?view=xamarin-forms) and defined the font size with the Key. Added the key to the [Resources](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.application.resources?view=xamarin-forms).
``` c#
namespace ListViewXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
        }
 
        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            DefineFontSize("FontSizeLarge", 38, 30);
            DefineFontSize("FontSizeBody", 48, 42);
            DefineFontSize("FontSizeSmall", 52, 48);
        }
 
        private void DefineFontSize(string resourceKey, int charsInLine, int linesInPage)
        {
            var size1 = Math.Round(Width / charsInLine) * 2;
            var size2 = Math.Round(Height / linesInPage);
            App.Current.Resources[resourceKey] = Math.Min(size1, size2);
        }
    }
}
```
**XAML**

Use the [DynamicResource](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.xaml.dynamicresourceextension?view=xamarin-forms) binding to the FontSize property.
``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ListViewXamarin"
             xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
             x:Class="ListViewXamarin.MainPage">
    <ContentPage.BindingContext>
        <local:ContactsViewModel/>
    </ContentPage.BindingContext>
 
  <ContentPage.Content>
        <StackLayout>
            <syncfusion:SfListView x:Name="listView" ItemSize="60" ItemsSource="{Binding ContactsInfo}">
                <syncfusion:SfListView.ItemTemplate >
                    <DataTemplate>
                        <Grid x:Name="grid">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="70" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            <Image Source="{Binding ContactImage}" VerticalOptions="Center" HorizontalOptions="Center" HeightRequest="50" WidthRequest="50"/>
                            <Grid Grid.Column="1" RowSpacing="1" Padding="10,0,0,0" VerticalOptions="Center">
                                <Label LineBreakMode="NoWrap" FontSize="{DynamicResource FontSizeSubtitle}" TextColor="#474747" Text="{Binding ContactName}"/>
                                <Label Grid.Row="1" Grid.Column="0" TextColor="#474747" LineBreakMode="NoWrap" FontSize="{DynamicResource FontSizeSmall}" Text="{Binding ContactNumber}"/>
                            </Grid>
                        </Grid>
                    </DataTemplate>
                </syncfusion:SfListView.ItemTemplate>
            </syncfusion:SfListView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```
**Output**

![FontSizeListView](https://github.com/SyncfusionExamples/font-size-listview-xamarin/blob/master/ScreenShots/FontSizeListView.jpg)
