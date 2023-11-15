using Shop.Data;
using UnityEngine;

namespace Shop.UI
{
    public class ShopUiController : MonoBehaviour
    {
        [SerializeField] private ShopUiBundleCard cardPrefab;
        [SerializeField] private ShopCatalog catalog;
        [SerializeField] private Transform cardsContent;

        private void Start()
        {
            FillList();
        }

        private void OnDestroy()
        {
            ClearList();
        }

        private void FillList()
        {
            foreach (var bundle in catalog.GetBundles())
            {
                var card = Instantiate(cardPrefab, cardsContent);
                card.Init(bundle);
            }
        }

        private void ClearList()
        {
            foreach (Transform cardTransform in cardsContent)
            {
                Destroy(cardTransform.gameObject);
            }
        }
    }
}
