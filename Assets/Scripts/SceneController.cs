using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject AreaExit;

    void Start()
    {
        AreaExit.SetActive(false);
    }

    void Update()
    {
        if (AllEnemiesDefeated())
        {
            AreaExit.SetActive(true);
        }
    }

    bool AllEnemiesDefeated()
    {
        
        GameObject[] blueSlimes = GameObject.FindGameObjectsWithTag("enemy");
        GameObject[] enemy2s = GameObject.FindGameObjectsWithTag("enemy2");
        Debug.Log("enemy: " + blueSlimes.Length + " | enemy2: " + enemy2s.Length);

        return blueSlimes.Length == 0 && enemy2s.Length == 0;
    }

    public void LoadNextScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Scene1")
        {
            SceneManager.LoadScene("Scene2");
        }
        else if (currentScene == "Scene2")
        {
            SceneManager.LoadScene("Scene3");
        }
        else
        {
            Debug.Log("Son sahneye ulaþýldý, daha ileriye geçilemiyor!");
        }
    }
}