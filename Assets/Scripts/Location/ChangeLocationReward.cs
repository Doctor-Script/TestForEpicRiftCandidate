using System;
using Core;
using UnityEngine;

namespace Location
{
    [Serializable]
    public class ChangeLocationReward : IReward
    {
        [SerializeField] private string location;
        
        void IReward.Apply()
        {
            LocationManager.Instance.SetLocation(location);
        }
    }
}
