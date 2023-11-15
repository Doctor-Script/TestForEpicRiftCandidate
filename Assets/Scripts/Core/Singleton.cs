using System;
using UnityEngine;

namespace Core
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static T Instance { get; private set; }
        
        private void Awake()
        {
            if (Instance != null)
            {
                throw new Exception("Duplicate instance of " + typeof(T));
            }

            Instance = (T)this;
        }

        private void Reset()
        {
            gameObject.name = GetType().Name;
        }
    }
}
