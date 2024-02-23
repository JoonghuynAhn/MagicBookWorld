using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBookWorld
{
    class AspectRatioContainer : ContentView
    {
        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return new SizeRequest(new Size(widthConstraint, heightConstraint * this.AspectRatio));
        }


        public static BindableProperty AspectRatioProperty = BindableProperty.Create(nameof(AspectRatio), typeof(double), typeof(AspectRatioContainer), (double)1);
        public double AspectRatio
        {
            get { return (double)this.GetValue(AspectRatioProperty); }
            set
            {
                this.SetValue(AspectRatioProperty, value);
            }
        }
    }
}
