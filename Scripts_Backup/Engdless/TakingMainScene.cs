using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakingMainScene : MonoBehaviour
{
    // private SceneManager sceneHome;

  

    public void HomeSceneButton()
    {
        SceneManager.LoadScene("RunnerUpMain");
    }
}
