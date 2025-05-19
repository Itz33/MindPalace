
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutSceneTransition : MonoBehaviour
{

    [SerializeField] VideoPlayer video;


    private void Awake()
    {
        video.loopPointReached += moveToNextScene;
        video.Play();
    }

    public void moveToNextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }

}
