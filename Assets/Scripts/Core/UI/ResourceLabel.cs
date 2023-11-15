using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    public abstract class ResourceLabel : MonoBehaviour
    {
        [SerializeField] private Button plusButton;
        [SerializeField] private TMP_Text valueText;

        private void Start()
        {
            plusButton.onClick.AddListener(OnButtonClicked);
            ResourceChangeNotifier.Instance.Changed += RefreshValue;
            RefreshValue();
        }

        private void OnDestroy()
        {
            ResourceChangeNotifier.Instance.Changed -= RefreshValue;
            plusButton.onClick.RemoveListener(OnButtonClicked);
        }

        protected void SetText(string text)
        {
            valueText.text = text;
        }

        protected abstract void OnButtonClicked();
        protected abstract void RefreshValue();
    }
}
