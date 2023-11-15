using Core;
using UnityEngine;

namespace Shop.Data
{
    [CreateAssetMenu(fileName = "NewShopCatalog", menuName = "Shop/Bundle", order = 0)]
    public class ShopBundle : ScriptableObject
    {
        [SerializeField] private string title;

        [SerializeReference, SelectImplementation(typeof(ISpendable))]
        private ISpendable price;
        
        [SerializeReference, SelectImplementation(typeof(IReward))]
        private IReward reward;

        public string Title => title;
        
        public ISpendable Price => price;
        public IReward Reward => reward;
    }
}
