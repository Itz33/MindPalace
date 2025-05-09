using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] playerPosition newplayerPosition;
    [SerializeField] private int sceneToChange;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        newplayerPosition.position = startPosition;
        SceneManager.LoadScene(sceneToChange);
    }

}
