using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Hello world, this is my first script.");
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
