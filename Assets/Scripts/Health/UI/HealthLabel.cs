using Core.UI;

namespace Health.UI
{
    public class HealthLabel : ResourceLabel
    {
        protected override void OnButtonClicked()
        {
            HealthManager.Instance.Increment();
        }

        protected override void RefreshValue()
        {
            SetText(HealthManager.Instance.CurrentHealth.ToString());
        }
    }
}
