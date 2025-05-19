using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SceneEnumAssigner;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] playerPosition newplayerPosition;
    [SerializeField] targetScene sceneToChange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        newplayerPosition.position = startPosition;
        SceneManager.LoadScene((int)sceneToChange);
    }

}
