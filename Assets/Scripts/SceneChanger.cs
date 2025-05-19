using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{


    public void ChangeToScene(SceneEnumAssigner enumClass)
    {
        int actualNumber = (int)enumClass.sceneToChange;
        SceneManager.LoadScene(actualNumber);
        Debug.Log(actualNumber);
    
    }

}
