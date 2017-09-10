using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer.Decorator
{
    public class DecoratorBase<T>
    {
        protected T _Component;

        protected object Invoke(string methodName, params object[] args)
        {
            if (_Component == null)
                return null;

            var mi = _Component.GetType().GetMethod(
                methodName,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            var res = mi.Invoke(_Component, args);
            return res;
        }

        [Inject]
        public void SetComponent([Named("Real")] T component)
        {
            _Component = component;
        }
    }
}
