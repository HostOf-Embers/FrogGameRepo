using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public string targetScene;
    public void ChangeScene(string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(targetScene);
    }

}