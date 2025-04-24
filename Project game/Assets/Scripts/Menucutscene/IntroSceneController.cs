using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements.InputSystem;

public class IntroSceneController : MonoBehaviour
{
    public Text txt;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }

        StartCoroutine(SceneCounter());
        
    }
    public IEnumerator SceneCounter()
    {  
        yield return new WaitForSecondsRealtime(43);
        SceneManager.LoadScene(2);
    }
}
