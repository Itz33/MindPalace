using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnHoverAction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] Sprite BaseSprite;
    [SerializeField] Sprite HoverSprite;
    [SerializeField] public Image ThisImage;
    [SerializeField] GameObject ToolTip;

    public void OnPointerEnter(PointerEventData eventData)
    {
        ThisImage.sprite = HoverSprite;
        activateTooltip();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ThisImage.sprite = BaseSprite;
        activateTooltip();
    }

    public void activateTooltip()
    {
        ToolTip.SetActive(!ToolTip.activeSelf);
    }

}
