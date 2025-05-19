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

   void Start()
   {
      player = GameObject.FindGameObjectWithTag("Player");
      if (newspaperText != null) newspaperText.gameObject.SetActive(false);
      if (newspaperImage != null) newspaperImage.gameObject.SetActive(false);
   }

   void Update()
   {
      if (player == null) return;
         //float check the distance with the player
         float distance = Vector3.Distance(transform.position, player.transform.position);
         isNear = distance <= interactionDistance;

         if (isNear && Input.GetKeyDown(KeyCode.E))
         {
            if (newspaperText != null) newspaperText.gameObject.SetActive(true);
            if (newspaperImage != null) newspaperImage.gameObject.SetActive(true);
            Destroy(gameObject);
         }
   }
   
}
