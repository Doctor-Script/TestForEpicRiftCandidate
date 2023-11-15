using System;
using Core;
using UnityEngine;

namespace Gold
{
    [Serializable]
    public class SpendGold : ISpendable
    {
        [SerializeField] private int value;
        
        void ISpendable.Spend()
        {
            GoldManager.Instance.Set(GoldManager.Instance.CurrentGold - value);
        }

        bool ISpendable.IsEnough()
        {
            return GoldManager.Instance.CurrentGold >= value;
        }
    }
}