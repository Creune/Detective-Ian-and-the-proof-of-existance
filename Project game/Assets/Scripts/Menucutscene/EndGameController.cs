using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour
{

    Scene currentScene;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        StartCoroutine(SceneCounter());
    }
    IEnumerator SceneCounter()
    {
        currentScene=SceneManager.GetActiveScene();
        if (currentScene.name=="InnocentKilled") {
            yield return new WaitForSecondsRealtime(15);
            SceneManager.LoadScene(0);
        }

        if (currentScene.name == "OutOfTime")
        {
            yield return new WaitForSecondsRealtime(18);
            SceneManager.LoadScene(0);
        }
        if (currentScene.name == "YouWon")
        {
            yield return new WaitForSecondsRealtime(10);
            SceneManager.LoadScene(0);
        }
    }
}
