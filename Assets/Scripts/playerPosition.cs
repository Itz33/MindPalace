using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NameOfTheFile", menuName = "My Scriptable Objects/ScriptableObjectClass")]
public class playerPosition : ScriptableObject
{
    // Start is called before the first frame update

    public Vector3 position = new Vector3 (0,-5.46f, 0);

    private void OnDisable()
    {
        position = new Vector3(0, -5.46f, 0);
    }

}
