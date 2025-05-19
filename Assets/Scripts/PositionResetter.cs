using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionResetter : MonoBehaviour
{
    [SerializeField] playerPosition positionToReset;

    public void Reset()
    {
    positionToReset.position = new Vector3(0, -5.46f, 0);
    }
}
