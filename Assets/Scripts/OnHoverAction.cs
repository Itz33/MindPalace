using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnHoverAction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    [SerializeField] Sprite BaseSprite;
    [SerializeField] Sprite HoverSprite;
    [SerializeField] public Image ThisImage;
    [SerializeField] GameObject ToolTip;


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hovering");
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

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(0);
    }
}
