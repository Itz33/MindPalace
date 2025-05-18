using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnHoverAction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] Sprite BaseSprite;
    [SerializeField] Sprite HoverSprite;
    [SerializeField] public Image ThisImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        ThisImage.sprite = HoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ThisImage.sprite = BaseSprite;
    }

}
