# How-to-add-the-MAUI-Charts-in-the-ListView
[.NET MAUI Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) provides support to add the chart inside the [SfListView](https://help.syncfusion.com/maui/listview/getting-started) control. You can add the chart in the [SfListView](https://help.syncfusion.com/maui/listview/getting-started)  with the help of the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate) property as shown in the following code sample.

 
**XAML**
 ```XAML
<list:SfListView x:Name="sfListView" ItemsSource="{Binding SeriesItems}" ItemSize="210" >
    <list:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <chart:SfCartesianChart  x:Name="chart"  Series="{Binding Series}">

                    <chart:SfCartesianChart.Title>
                        <Label Text="{Binding ChartTitle}" HorizontalOptions="Center" FontAttributes="Bold"></Label>
                    </chart:SfCartesianChart.Title>

                    <chart:SfCartesianChart.XAxes>
                        <chart:CategoryAxis></chart:CategoryAxis>
                    </chart:SfCartesianChart.XAxes>

                    <chart:SfCartesianChart.YAxes>
                        <chart:NumericalAxis></chart:NumericalAxis>
                    </chart:SfCartesianChart.YAxes>

                </chart:SfCartesianChart>
            </ViewCell>
        </DataTemplate>
    </list:SfListView.ItemTemplate>

</list:SfListView>
 ```
 


 **C#**
 ```C#
 public class Model
 {
     public Model(string x, double y)
     {
         XValue = x;
         YValue = y;
     }

     public string XValue { get; set; }

     public double YValue { get; set; }
 }
 ```
 

**C#**
 
 ```C#
 public class SeriesViewModel
 {
     public SeriesViewModel()
     {
         Data1 = new ObservableCollection<Model>();
         Data2 = new ObservableCollection<Model>();
         Data3 = new ObservableCollection<Model>();

         Data1.Add(new Model("Jan", 10));
         Data1.Add(new Model("Feb", 15));
         Data1.Add(new Model("Mar", 20));
         Data1.Add(new Model("Apr", 15));
         Data1.Add(new Model("May", 10));

         Data2.Add(new Model("EEE", 20));
         Data2.Add(new Model("CSE", 35));
         Data2.Add(new Model("ECE", 10));
         Data2.Add(new Model("Civil", 25));
         Data2.Add(new Model("IT", 14));

         Data3.Add(new Model("Benz", 13));
         Data3.Add(new Model("Audi", 18));
         Data3.Add(new Model("Volvo", 29));
         Data3.Add(new Model("BMW", 17));
         Data3.Add(new Model("Jaguar", 19));
     }

     public ObservableCollection<Model> Data1 { get; set; }

     public ObservableCollection<Model> Data2 { get; set; }

     public ObservableCollection<Model> Data3 { get; set; }

     public string? ChartTitle { get; set; }

     public ChartSeriesCollection? Series { get; set; }
 }
 ```


**C#**

 
 ```C#
public class ViewModel
{
    public ObservableCollection<SeriesViewModel> SeriesItems { get; set; }

    public ViewModel()
    {
        SeriesItems = new ObservableCollection<SeriesViewModel>();
        SeriesViewModel model = new SeriesViewModel();
       

        SeriesItems.Add(new SeriesViewModel()
        {
            ChartTitle = "Column Chart",
            Series = new ChartSeriesCollection(){ new ColumnSeries(){
                    ItemsSource=model.Data2,
                    XBindingPath="XValue",
                    YBindingPath="YValue"
                } },
            
        });

        SeriesItems.Add(new SeriesViewModel()
        {
            ChartTitle = "Line Chart",
            Series = new ChartSeriesCollection(){ new LineSeries(){
                    ItemsSource=model.Data3,
                    XBindingPath="XValue",
                    YBindingPath="YValue"
                } },
        });

        SeriesItems.Add(new SeriesViewModel()
        {
            ChartTitle = "Spline Chart",
            Series = new ChartSeriesCollection(){ new SplineSeries(){
                    ItemsSource=model.Data1,
                    XBindingPath="XValue",
                    YBindingPath="YValue"
                } },
        });
    }
}
 ```
 


**Output**

![image.png](https://support.syncfusion.com/kb/agent/attachment/article/15556/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE5ODExIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.LrzMhWc-TlG9nq6NmFxc38Kd_MdRWXeHEOGFgZfhydI)


## Troubleshooting

### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

