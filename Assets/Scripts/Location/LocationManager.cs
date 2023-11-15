using Core;
using UnityEngine;

namespace Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        [SerializeField] private string currentLocation;

        private void Start()
        {
            DefaultLocation = currentLocation;
        }

        public void SetLocation(string value)
        {
            if (!currentLocation.Equals(value))
            {
                currentLocation = value;
                ResourceChangeNotifier.Instance.Notify();
            }
        }
        
        public string CurrentLocation => currentLocation;

        public string DefaultLocation { get; private set; }
    }
}
