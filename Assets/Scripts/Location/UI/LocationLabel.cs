using Core.UI;

namespace Location.UI
{
    public class LocationLabel : ResourceLabel
    {
        protected override void OnButtonClicked()
        {
            LocationManager.Instance.SetLocation(LocationManager.Instance.DefaultLocation);
        }

        protected override void RefreshValue()
        {
            SetText(LocationManager.Instance.CurrentLocation);
        }
    }
}
