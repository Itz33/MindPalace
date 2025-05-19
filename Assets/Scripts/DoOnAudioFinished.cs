using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoOnAudioFinished : MonoBehaviour
{
    [SerializeField] AudioSource audioToWait;
    [SerializeField] UnityEvent doAfterAudio;
    [SerializeField]   playerPosition playerPosition;
    [SerializeField] Vector3 posi;
    private void Start()
    {
        
    }

    public void checkAudio()
    {
        StartCoroutine(WaitForAudioFinish());
    }

    private IEnumerator WaitForAudioFinish()
    {
        while (audioToWait.isPlaying)
        {
            yield return null; // Wait for the next frame
        }

        doAfterAudio.Invoke();  
        playerPosition.position = posi;
    }
}
