using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSecretDoor : MonoBehaviour
{
    
    public static bool cuchilloFound {get; private set;} = false;
    
   public void activateDoor()
    {
        cuchilloFound = true;
    }

}
