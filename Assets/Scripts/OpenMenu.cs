using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenMenu : MonoBehaviour
{
    [SerializeField] UnityEvent openMenuEvent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            openMenuEvent.Invoke();
        }     
    }

    public void setMenuVisible(GameObject menu)
    {

        menu.SetActive(!menu.activeSelf);
    }


}
