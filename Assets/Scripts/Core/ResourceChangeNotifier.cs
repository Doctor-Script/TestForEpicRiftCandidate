using System;

namespace Core
{
    public class ResourceChangeNotifier : Singleton<ResourceChangeNotifier>
    {
        public event Action Changed;

        public void Notify()
        {
            Changed?.Invoke();
        }
    }
}
