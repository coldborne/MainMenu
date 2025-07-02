using UnityEngine;
using UnityEngine.UI;

public class CreditView : MonoBehaviour
{
    [SerializeField] private Canvas _mainMenuCanvas;
    [SerializeField] private Image _creditPanel;

    public void ShowCreditPanel()
    {
        _creditPanel.gameObject.SetActive(true);
    }

    public void HideCreditPanel()
    {
        _creditPanel.gameObject.SetActive(false);
    }
}
