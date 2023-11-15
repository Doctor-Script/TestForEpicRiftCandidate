using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class AddHealthReward : IReward
    {
        [SerializeField] private int value;
        
        void IReward.Apply()
        {
            HealthManager.Instance.Set(HealthManager.Instance.CurrentHealth + value);
        }
    }
}
