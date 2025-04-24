using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour
{
    Scene scene;
    bool restart=false;
    private static SoundController instance;

    public static SoundController Instance {  get { return instance; } }

    void Awake()
    {

        

        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        scene=SceneManager.GetActiveScene();
        if (scene.name != "MainMenu")
        {
            restart=true;
        }

        if (scene.name == "MainMenu"&&restart)
        {
            Destroy(this.gameObject);
        }
    }


}
