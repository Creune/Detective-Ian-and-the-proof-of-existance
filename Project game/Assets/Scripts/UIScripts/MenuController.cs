using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject menu;
    public GameObject playerUI;
    bool menuState;

    public GameObject aliveTab;
    public bool tabOpen;
    public GameObject player;

    public Button resume;
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        menuState = false;
        resume.onClick.AddListener(Resume);
        exit.onClick.AddListener(Exit);

        tabOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        menu.SetActive(menuState);
        playerUI.SetActive(!menuState);
        StateCheck();
        GameStateChanger();

        aliveTab.SetActive(tabOpen);
        TabControl();
    }

    void StateCheck()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!menuState)
            {
                menuState = true;
            }
            else
            {
                menuState = false;
            }
        }
       
    }

    void GameStateChanger()
    {
        if(menuState)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Resume()
    {
        menuState= false;
    }

    public void Exit()
    {

        SceneManager.LoadScene(0);
    }

    void TabControl() {

        if(Input.GetKeyDown(KeyCode.Tab)){
            if (tabOpen)
            {
                tabOpen = false;
                player.GetComponent<PlayerController>().enabled = true;
            }
            else { 
                tabOpen= true;
                player.GetComponent<PlayerController>().enabled = false;
            }
        }

    }
}
