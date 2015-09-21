using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steam_ACF_Viewer.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}
