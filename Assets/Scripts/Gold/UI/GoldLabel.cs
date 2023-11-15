using Core.UI;

namespace Gold.UI
{
    public class GoldLabel : ResourceLabel
    {
        protected override void OnButtonClicked()
        {
            GoldManager.Instance.Increment();
        }

        protected override void RefreshValue()
        {
            SetText(GoldManager.Instance.CurrentGold.ToString());
        }
    }
}
