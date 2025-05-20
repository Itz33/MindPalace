using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{

    public static InventorySystem instance;

    public List<NewspaperEntry> newspapers;
    public GameObject inventoryPanel;
    public GameObject newspaperUIprefab;

    public GameObject informationPanel;
    public GameObject imagePanel;

    private Dictionary<string, GameObject> activeUIItems = new Dictionary<string, GameObject>();
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeInventory();
        }
        else
        {
            Destroy(gameObject);
        }
        SceneManager.sceneLoaded += OnSceneLoaded;

    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;

    }

    void InitializeInventory()
    {
        informationPanel = GameObject.Find("Information_Desc");
        if (informationPanel == null) { Debug.Log("NoLoEncontramos"); }
        imagePanel = GameObject.Find("NewspaperImage");

        if (inventoryPanel != null)
        {
            DontDestroyOnLoad(inventoryPanel.transform.root.gameObject);
        }

        foreach (var paper in newspapers)
        {
            if (paper.collected)
            {
                Debug.Log("Checking on NewsPaper");
                AddNewspaper(paper);
            }
        }
    }

    void AddNewspaper(NewspaperEntry paper)
    {
        informationPanel.gameObject.SetActive(paper.collected);
        Debug.Log("InfoHasBeenActivated");
        imagePanel.gameObject.SetActive(paper.collected);

        if (inventoryPanel == null || newspaperUIprefab == null) return;
        
        var newItem = Instantiate(newspaperUIprefab, inventoryPanel.transform);

        var image = newItem.transform.Find("Image")?.GetComponent<Image>();
        var text  = newItem.transform.Find("Text")?.GetComponent<TMP_Text>();

        if (image != null) image.sprite = paper.image;
        if (text != null) text.text = paper.text;
        
        activeUIItems[paper.id] = newItem;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        InitializeInventory();
        // Add your logic here to be executed on each scene load
    }

}

[System.Serializable]
public class NewspaperEntry
{
    // Start is called before the first frame update
    public string id;
    public Sprite image;
    public string text;
    public bool collected = false;
}