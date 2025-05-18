using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToolTipScript : MonoBehaviour
{
    [SerializeField] TMP_Text toolText;
    [SerializeField] string toolName;
    
    // Start is called before the first frame update
    void Start()
    {
        toolText.text = toolName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
