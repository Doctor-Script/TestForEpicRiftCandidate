using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class SpendHealthPercent : ISpendable
    {
        [SerializeField, Range(0f, 1f)] private float valuePercent;
        
        void ISpendable.Spend()
        {
            HealthManager.Instance.Set(CalculateValue());
        }

        bool ISpendable.IsEnough()
        {
            var currentHealth = HealthManager.Instance.CurrentHealth;
            return currentHealth > 0 && currentHealth >= CalculateValue();
        }

        private int CalculateValue()
        {
            var currentHealth = HealthManager.Instance.CurrentHealth;
            return (int)(currentHealth * (1f - valuePercent));
        }
    }
}