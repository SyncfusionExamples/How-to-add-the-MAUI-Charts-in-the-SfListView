 
namespace ChartListView
{
    public class Model
    { 
        public string XValue { get; set; }
        public double YValue { get; set; }
        public Model(string x, double y)
        {
            XValue = x;
            YValue = y;
        }
    }
}
