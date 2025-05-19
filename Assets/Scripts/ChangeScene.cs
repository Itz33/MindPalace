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
    [SerializeField] private float messageDisplayTime = 2f;
    [SerializeField] private GameObject messageUI; // Optional: Assign a UI panel in Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (requiresNewspaper && !NewspaperItem.NewspaperPickedUp)
            {
                ShowMessage("You need to read the newspaper first!");
                return;
            }
            
            newplayerPosition.position = startPosition;
            SceneManager.LoadScene((int)sceneToChange);
        }
    }

    private void ShowMessage(string message)
    {
        Debug.Log(message);
        
        // If you have UI for messages
        if (messageUI != null)
        {
            if (messageUI.TryGetComponent<TextMeshProUGUI>(out var textComponent))
            {
                textComponent.text = message;
            }
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