using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : Singleton<SceneManagement>
{
    public string SceneTransitionName { get; private set; }

    public void SetTransitionName(string sceneTransitionName)
    {
        this.SceneTransitionName = sceneTransitionName;
    }

    public void LoadNextScene()
    {
        if (!string.IsNullOrEmpty(SceneTransitionName))
        {
            SceneManager.LoadScene(SceneTransitionName);
        }
        else
        {
            Debug.LogError("Geçiþ yapacak sahne adý belirlenmemiþ!");
        }
    }

}
