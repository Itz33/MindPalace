using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Controller : MonoBehaviour
{

    public GameObject menuCanvas;

    public Image newspaperImageUI;

    public TMP_Text newspaperInformationUI;
    // Start is called before the first frame update
    void Start()
    {
        bool activate;
        menuCanvas.SetActive(false);
        if (InventorySystem.instance.newspapers.Count == 0)
        {
            activate = false;
        }
        else
        {
            activate = InventorySystem.instance.newspapers[0].collected;
        }


            newspaperImageUI.gameObject.SetActive(activate);
        newspaperInformationUI.gameObject.SetActive(activate);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            menuCanvas.SetActive(!menuCanvas.activeSelf);

            if (menuCanvas.activeSelf)
            {
                // UpdateNewsPaperUI(); 
            }
            else
            {
                //newspaperImageUI.gameObject.SetActive(false);
                //newspaperInformationUI.gameObject.SetActive(false);
            }
        }
    }
    
}
