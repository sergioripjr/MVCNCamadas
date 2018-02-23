using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace NorthwindApp.DependencyResolution
{
    class WebContextLifetimeManager : Microsoft.Practices.Unity.LifetimeManager
    {
        private string _key;
        public override void SetValue(object newValue)
        {
            _key = newValue.GetType().FullName;
            HttpContext.Current.Items[_key] = newValue;
        }
        public override object GetValue()
        {
            return _key == null ? null : HttpContext.Current.Items[_key];
        }
        public override void RemoveValue()
        {
            var value = HttpContext.Current.Items[_key] as IDisposable;
            if (value != null)
                value.Dispose();            
        }
    }
}
