using Core;
using Shop.Data;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace Shop.UI
{
    public class ShopUiBundleCard : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI title;
        [SerializeField] private Button buyButton;

        private IReward reward;
        private ISpendable price;
        
        public void Init(ShopBundle bundle)
        {
            ResourceChangeNotifier.Instance.Changed += RefreshButton;
            
            reward = bundle.Reward;
            price = bundle.Price;

            title.text = bundle.Title;
            buyButton.onClick.AddListener(OnBuyClick);
            RefreshButton();
        }

        private void OnDestroy()
        {
            buyButton.onClick.RemoveListener(OnBuyClick);
            ResourceChangeNotifier.Instance.Changed -= RefreshButton;
        }

        private void OnBuyClick()
        {
            Assert.IsTrue(price.IsEnough());
            price.Spend();
            reward.Apply();
        }

        private void RefreshButton()
        {
            buyButton.interactable = price.IsEnough();
        }
    }
}
