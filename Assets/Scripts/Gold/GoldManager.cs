using Core;
using UnityEngine;
using UnityEngine.Assertions;

namespace Gold
{
    public class GoldManager : Singleton<GoldManager>
    {
        [SerializeField] private int currentGold;
        [SerializeField] private int increment;

        public void Set(int value)
        {
            Assert.IsTrue(value >= 0);
            currentGold = value;
            ResourceChangeNotifier.Instance.Notify();
        }

        public void Increment()
        {
            Set(currentGold + increment);
        }

        public int CurrentGold => currentGold;
    }
}
