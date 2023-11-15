using System;
using Core;
using UnityEngine;
using UnityEngine.Assertions;

namespace Health
{
    public class HealthManager : Singleton<HealthManager>
    {
        [SerializeField] private int currentHealth;
        [SerializeField] private int maxHealth;
        [SerializeField] private int increment;

        public void Set(int value)
        {
            Assert.IsTrue(value >= 0);
            currentHealth = value;
            currentHealth = Math.Clamp(currentHealth, 0, maxHealth);
            ResourceChangeNotifier.Instance.Notify();
        }

        public int CurrentHealth => currentHealth;

        public void Increment()
        {
            Set(currentHealth + increment);
        }
    }
}
