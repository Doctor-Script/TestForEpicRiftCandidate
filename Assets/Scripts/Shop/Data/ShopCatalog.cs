using System.Collections.Generic;
using UnityEngine;

namespace Shop.Data
{
    [CreateAssetMenu(fileName = "NewShopCatalog", menuName = "Shop/Catalog", order = 0)]
    public class ShopCatalog : ScriptableObject
    {
        [SerializeField] private List<ShopBundle> bundles;

        public IReadOnlyCollection<ShopBundle> GetBundles()
        {
            return bundles;
        }
    }
}
