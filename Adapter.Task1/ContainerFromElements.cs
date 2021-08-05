using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Task1
{
    public class ContainerFromElements<T> : IContainer<T>
    {

        private readonly IElements<T> elements;

        public ContainerFromElements(IElements<T> elements)
        {
            this.elements = elements;
        }

        public IEnumerable<T> Items => elements.GetElements();

        public int Count => GetElementsCount();

        private int GetElementsCount()
        {
            int result = 0;
            using (IEnumerator<T> enumerator = elements.GetElements().GetEnumerator())
            {
                while (enumerator.MoveNext())
                    result++;
            }
            return result;
        }
    }
}
