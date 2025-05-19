using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableItem : MonoBehaviour
{
    [Header("Interaction")]
    public float interactionDistance = 2f;
    private GameObject player;
    private bool isNear = false;

    [SerializeField] UnityEvent interact;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    private void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.transform.position);
        isNear = distance <= interactionDistance;

        if (isNear && Input.GetKeyDown(KeyCode.E))
        {
            interact.Invoke();
        }
    }
}
