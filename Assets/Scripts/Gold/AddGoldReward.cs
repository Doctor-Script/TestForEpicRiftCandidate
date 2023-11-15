using System;
using Core;
using UnityEngine;

namespace Gold
{
    [Serializable]
    public class AddGoldReward : IReward
    {
        [SerializeField] private int value;
        
        void IReward.Apply()
        {
            GoldManager.Instance.Set(GoldManager.Instance.CurrentGold + value);
        }
    }
}