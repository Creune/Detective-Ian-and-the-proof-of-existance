using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Text timer;
    public RoleCall rolecall;

    public GameObject lobbyHighlight;
    public GameObject gR1Highlight;
    public GameObject gR2Highlight;
    public GameObject gR3Highlight;
    public GameObject gR4Highlight;
    public GameObject diningHighlight;
    public GameObject kitchenHighlight;
    public GameObject garageHighlight;
    public GameObject pantryHighlight;
    public GameObject musicHighlight;
    public GameObject gameHighlight;
    public GameObject storageHighlight;
    public GameObject warHighlight;
    public GameObject utilityHighlight;
    public GameObject bathrHighlight;
    public GameObject libraryHighlight;
    public GameObject loungeHighlight;
    public GameObject mBedrHighlight;
    public GameObject mBathHighlight;
    public GameObject studyHighlight;
    public GameObject trophyHighlight;
    public GameObject officeHighlight;
    public GameObject hallwayHighlight;
    public NPCLocationController locationController;

    public Text textPopups;
    public List<string> popupTextList=new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        textPopups.text = "";
       
    }

    // Update is called once per frame
    void Update()
    {
        TimerCount();
        TextPrint();
        MapManagement();
    }

    public void TimerCount() {

        if (rolecall.realMinutes < 10 && rolecall.realSeconds < 10)
        {
            timer.text = "0" + rolecall.realMinutes + ":0" + rolecall.realSeconds;
        }
        else if (rolecall.realMinutes < 10 && rolecall.realSeconds >= 10)
        {
            timer.text = "0" + rolecall.realMinutes + ":" + rolecall.realSeconds;
        }
        else if (rolecall.realMinutes >= 10 && rolecall.realSeconds < 10)
        {
            timer.text = rolecall.realMinutes + ":0" + rolecall.realSeconds;
        }
        else if (rolecall.realMinutes >= 10 && rolecall.realSeconds >= 10)
        {
            timer.text = rolecall.realMinutes + ":" + rolecall.realSeconds;
        }
        

        
    }

    public void TextPrint() {

        
            foreach (string text in popupTextList)
            {
                textPopups.text = text + "\n"+textPopups.text;
            }
            popupTextList.Clear();



    }

    public void MapManagement()
    {
        if (locationController.playerInLobby)
        {
            lobbyHighlight.SetActive(true);
        }
        else
        {
            lobbyHighlight.SetActive(false);
        }

        if (locationController.playerInGuestRoom1)
        {
            gR1Highlight.SetActive(true);
        }
        else
        {
            gR1Highlight.SetActive(false);
        }

        if (locationController.playerInGuestRoom2)
        {
            gR2Highlight.SetActive(true);
        }
        else
        {
            gR2Highlight.SetActive(false);
        }

        if (locationController.playerInGuestRoom3)
        {
            gR3Highlight.SetActive(true);
        }
        else
        {
            gR3Highlight.SetActive(false);

        }

        if (locationController.playerInGuestRoom4)
        {
            gR4Highlight.SetActive(true);
        }
        else
        {
            gR4Highlight.SetActive(false);
        }

        if (locationController.playerInDiningRoom)
        {
            diningHighlight.SetActive(true);
        }
        else
        {
            diningHighlight.SetActive(false);
        }

        if (locationController.playerInKitchen)
        {
            kitchenHighlight.SetActive(true);
        }
        else
        {
            kitchenHighlight.SetActive(false);
        }

        if (locationController.playerInGarage)
        {
            garageHighlight.SetActive(true);
        }
        else
        {
            garageHighlight.SetActive(false);
        }

        if (locationController.playerInPantry)
        {
            pantryHighlight.SetActive(true);
        }
        else
        {
            pantryHighlight.SetActive(false);
        }

        if (locationController.playerInMusicRoom)
        {
            musicHighlight.SetActive(true);
        }
        else
        {
            musicHighlight.SetActive(false);
        }

        if (locationController.playerInGameRoom)
        {
            gameHighlight.SetActive(true);
        }
        else
        {
            gameHighlight.SetActive(false);
        }

        if (locationController.playerInStorage)
        {
            storageHighlight.SetActive(true);
        }
        else
        {
            storageHighlight.SetActive(false);
        }

        if (locationController.playerInWarRoom)
        {
            warHighlight.SetActive(true);
        }
        else
        {
            warHighlight.SetActive(false);
        }

        if (locationController.playerInUtility)
        {
            utilityHighlight.SetActive(true);
        }
        else
        {
            utilityHighlight.SetActive(false);
        }

        if (locationController.playerInBathroom)
        {
            bathrHighlight.SetActive(true);
        }
        else
        {
            bathrHighlight.SetActive(false);
        }

        if (locationController.playerInLibrary)
        {
            libraryHighlight.SetActive(true);
        }
        else
        {
            libraryHighlight.SetActive(false);
        }

        if (locationController.playerInLounge)
        {
            loungeHighlight.SetActive(true);
        }
        else
        {
            loungeHighlight.SetActive(false);
        }

        if (locationController.playerInMasterBedroom)
        {
            mBedrHighlight.SetActive(true);
        }
        else
        {
            mBedrHighlight.SetActive(false);
        }

        if (locationController.playerInMasterBathroom)
        {
            mBathHighlight.SetActive(true);
        }
        else
        {
            mBathHighlight.SetActive(false);
        }

        if (locationController.playerInOffice)
        {
            officeHighlight.SetActive(true);
        }
        else
        {
            officeHighlight.SetActive(false);
        }

        if (locationController.playerInTrophyRoom)
        {
            trophyHighlight.SetActive(true);
        }
        else
        {
            trophyHighlight.SetActive(false);
        }

        if (locationController.playerInStudy)
        {
            studyHighlight.SetActive(true);
        }
        else
        {
            studyHighlight.SetActive(false);
        }

        if (locationController.playerInHallway)
        {
            hallwayHighlight.SetActive(true);
        }
        else
        {
            hallwayHighlight.SetActive(false);
        }

    }

}
