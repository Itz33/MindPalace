using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayIfCondition : MonoBehaviour
{
    [SerializeField] AudioSource audioToPlay;

    private void Awake()
    {
        if (OpenSecretDoor.cuchilloFound)
        {
            audioToPlay.Play();
        }
    }
    private void Start()
    {
        
        
        
    }

}
