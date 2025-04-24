using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillSwitch : MonoBehaviour
{
    public PlayerUIController playerUI;
    public PlayerController playerController;
    public MenuController menuController;

    private void OnMouseDown()
    {
        if (!menuController.tabOpen)
        {
            if (gameObject.GetComponent<MurderController>().enabled && !playerController.shot)
            {
                
                playerController.shot = true;
                SceneManager.LoadScene(5);
            }
            else if (!gameObject.GetComponent<MurderController>().enabled && !gameObject.GetComponent<BodyController>().enabled && !playerController.shot)
            {
                
                playerController.shot = true;
                SceneManager.LoadScene(4);
            }
        }
    }


}
