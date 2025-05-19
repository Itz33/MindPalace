using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEnumAssigner : MonoBehaviour
{    
    public enum targetScene
    {
        CutScene,
        MainMenu,
        LoadScene,
        Lobby,
        MainHall,
        Kitchen,
        Corridor,
        BedRoom
    };


    public targetScene sceneToChange;
}
