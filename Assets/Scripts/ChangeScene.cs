using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using static SceneEnumAssigner;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] playerPosition newplayerPosition;
    [SerializeField] targetScene sceneToChange;
    
    [Header("Newspaper Check")]
    [SerializeField] private bool requiresNewspaper = false;
    [SerializeField] private bool requiresCuchillo = false;
    [SerializeField] private float messageDisplayTime = 2f;
    [SerializeField] private GameObject messageUI; // Optional: Assign a UI panel in Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (requiresNewspaper && !NewspaperItem.NewspaperPickedUp)
            {
                ShowMessage("Debes leer el periódico antes");
                return;
            }
            if (requiresCuchillo && !OpenSecretDoor.cuchilloFound)
            {
                ShowMessage("Debes encontrar una pista antes");
                return;
            }


        }
        newplayerPosition.position = startPosition;
        SceneManager.LoadScene((int)sceneToChange);
    }

    private void ShowMessage(string message)
    {
        Debug.Log(message);
        
        // If you have UI for messages
        if (messageUI != null)
        {


            messageUI.GetComponentInChildren<TextMeshProUGUI>().text = message;
            
            messageUI.SetActive(true);
            Invoke("HideMessage", messageDisplayTime);
        }
    }

    private void HideMessage()
    {
        if (messageUI != null)
        {
            messageUI.SetActive(false);
        }
    }
}