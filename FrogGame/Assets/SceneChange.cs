using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public string targetScene;
    //public scene change, when player clicks button directs them to "inserted target scene"
    //change scene title as required per use
    public void ChangeScene(string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);
    }

    //when player enters a trigger, direct them to "target scene"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(targetScene);
    }

}