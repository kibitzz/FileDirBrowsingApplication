using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorerApp.Common
{
    public class IoC
    {

        public static IUnityContainer _container;
        public static object _createInstanceLocker = new object();

        public static IUnityContainer Instance
        {
            get
            {
                if (_container == null)
                {
                    lock (_createInstanceLocker)
                    {
                        if (_container == null)
                            _container = new UnityContainer();
                    }
                }

                return _container;
            }
        }

        public static T Get<T>()
        {
            return Instance.Resolve<T>();
        }
    }
}
