using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class SpendHealth : ISpendable
    {
        [SerializeField] private int value;
        
        void ISpendable.Spend()
        {
            HealthManager.Instance.Set(HealthManager.Instance.CurrentHealth - value);
        }

        bool ISpendable.IsEnough()
        {
            return HealthManager.Instance.CurrentHealth >= value;
        }
    }
}
