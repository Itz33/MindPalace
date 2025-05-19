using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField] AudioSource audioToSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!OpenSecretDoor.cuchilloFound) audioToSound.Play();

    }

}
