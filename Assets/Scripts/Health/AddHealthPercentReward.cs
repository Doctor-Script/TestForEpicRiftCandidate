using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class AddHealthPercentReward : IReward
    {
        [SerializeField, Range(0f, 1f)] private float percent;
        
        void IReward.Apply()
        {
            var currentHealth = HealthManager.Instance.CurrentHealth;
            var newValue = (int)(currentHealth * (1f + percent));
            HealthManager.Instance.Set(newValue);
        }
    }
}