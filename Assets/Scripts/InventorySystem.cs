using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{

    public static InventorySystem instance;

    [System.Serializable]
    public class NewspaperEntry
    {
        public string id;
        public Sprite image;
        public string text;
        [HideInInspector] public bool collected = false;
    }

    public List<NewspaperEntry> newspapers;
    public GameObject inventoryPanel;
    public GameObject newspaperUIprefab;

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
    }

    void InitializeInventory()
    {
        if (inventoryPanel != null)
        {
            DontDestroyOnLoad(inventoryPanel.transform.root.gameObject);
        }

        foreach (var paper in newspapers)
        {
            if (paper.collected)
            {
                AddNewspaper(paper);
            }
        }
    }

    void AddNewspaper(NewspaperEntry paper)
    {
        if (inventoryPanel == null || newspaperUIprefab == null) return;
        
        var newItem = Instantiate(newspaperUIprefab, inventoryPanel.transform);

        var image = newItem.transform.Find("Image")?.GetComponent<Image>();
        var text  = newItem.transform.Find("Text")?.GetComponent<TMP_Text>();

        if (image != null) image.sprite = paper.image;
        if (text != null) text.text = paper.text;
        
        activeUIItems[paper.id] = newItem;
    }
    
}
