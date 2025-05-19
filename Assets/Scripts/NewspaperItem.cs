using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperItem : MonoBehaviour
{
   public float interactionDistance = 2f;
   private GameObject player;
   private bool isNear = false;
    
   public TMP_Text newspaperText;
   public Image newspaperImage;
    
   // Static property to track pickup status
   public static bool NewspaperPickedUp { get; private set; } = false;

   void Start()
   {
      player = GameObject.FindGameObjectWithTag("Player");
      if (newspaperText != null) newspaperText.gameObject.SetActive(false);
      if (newspaperImage != null) newspaperImage.gameObject.SetActive(false);
   }

   void Update()
   {
      if (player == null) return;
        
      float distance = Vector3.Distance(transform.position, player.transform.position);
      isNear = distance <= interactionDistance;

      if (isNear && Input.GetKeyDown(KeyCode.E))
      {
         PickUpNewspaper();
      }
   }
    
   private void PickUpNewspaper()
   {
      if (newspaperText != null) newspaperText.gameObject.SetActive(true);
      if (newspaperImage != null) newspaperImage.gameObject.SetActive(true);
        
      NewspaperPickedUp = true; // Set the static flag
      Destroy(gameObject);
      
   }
}
