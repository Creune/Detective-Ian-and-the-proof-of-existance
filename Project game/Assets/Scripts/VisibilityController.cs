using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityController : MonoBehaviour
{
    public GameObject lobbyDark;
    public GameObject guestroom1Dark;
    public GameObject guestroom2Dark;
    public GameObject guestroom3Dark;
    public GameObject guestroom4Dark;
    public GameObject diningRoomDark;
    public GameObject kitchenDark;
    public GameObject garageDark;
    public GameObject pantryDark;
    public GameObject musicRoomDark;
    public GameObject gameRoomDark;
    public GameObject storageDark;
    public GameObject warRoomDark;
    public GameObject utilityDark;
    public GameObject bathroomDark;
    public GameObject libraryDark;
    public GameObject loungeDark;
    public GameObject masterBedroomDark;
    public GameObject masterBathroomDark;
    public GameObject studyDark;
    public GameObject officeDark;
    public GameObject trophyRoomDark;
    public GameObject hallwayDark;
    public NPCLocationController npcLocation;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (npcLocation.playerInLobby) {
            lobbyDark.SetActive(false);
        }
        else { 
            lobbyDark.SetActive(true);
        }


        if (npcLocation.playerInGuestRoom1)
        {
            guestroom1Dark.SetActive(false);
        }
        else
        {
            guestroom1Dark.SetActive(true);
        }


        if (npcLocation.playerInGuestRoom2)
        {
            guestroom2Dark.SetActive(false);
        }
        else
        {
            guestroom2Dark.SetActive(true);
        }


        if (npcLocation.playerInGuestRoom3)
        {
            guestroom3Dark.SetActive(false);
        }
        else
        {
            guestroom3Dark.SetActive(true);
        }


        if (npcLocation.playerInGuestRoom4)
        {
            guestroom4Dark.SetActive(false);
        }
        else
        {
            guestroom4Dark.SetActive(true);
        }


        if (npcLocation.playerInDiningRoom)
        {
            diningRoomDark.SetActive(false);
        }
        else
        {
            diningRoomDark.SetActive(true);
        }


        if (npcLocation.playerInKitchen)
        {
            kitchenDark.SetActive(false);
        }
        else
        {
            kitchenDark.SetActive(true);
        }


        if (npcLocation.playerInGarage)
        {
            garageDark.SetActive(false);
        }
        else
        {
            garageDark.SetActive(true);
        }


        if (npcLocation.playerInPantry)
        {
            pantryDark.SetActive(false);
        }
        else
        {
            pantryDark.SetActive(true);
        }


        if (npcLocation.playerInMusicRoom)
        {
            musicRoomDark.SetActive(false);
        }
        else
        {
            musicRoomDark.SetActive(true);
        }


        if (npcLocation.playerInGameRoom)
        {
            gameRoomDark.SetActive(false);
        }
        else
        {
            gameRoomDark.SetActive(true);
        }


        if (npcLocation.playerInStorage)
        {
            storageDark.SetActive(false);
        }
        else
        {
            storageDark.SetActive(true);
        }


        if (npcLocation.playerInWarRoom)
        {
            warRoomDark.SetActive(false);
        }
        else
        {
            warRoomDark.SetActive(true);
        }


        if (npcLocation.playerInUtility)
        {
            utilityDark.SetActive(false);
        }
        else
        {
            utilityDark.SetActive(true);
        }


        if (npcLocation.playerInBathroom)
        {
            bathroomDark.SetActive(false);
        }
        else
        {
            bathroomDark.SetActive(true);
        }


        if (npcLocation.playerInLibrary)
        {
            libraryDark.SetActive(false);
        }
        else
        {
            libraryDark.SetActive(true);
        }


        if (npcLocation.playerInLounge)
        {
            loungeDark.SetActive(false);
        }
        else
        {
            loungeDark.SetActive(true);
        }

        if (npcLocation.playerInMasterBedroom)
        {
            masterBedroomDark.SetActive(false);
        }
        else
        {
            masterBedroomDark.SetActive(true);
        }


        if (npcLocation.playerInMasterBathroom)
        {
            masterBathroomDark.SetActive(false);
        }
        else
        {
            masterBathroomDark.SetActive(true);
        }

        if (npcLocation.playerInOffice)
        {
            officeDark.SetActive(false);
        }
        else
        {
            officeDark.SetActive(true);
        }

        if (npcLocation.playerInTrophyRoom)
        {
            trophyRoomDark.SetActive(false);
        }
        else
        {
            trophyRoomDark.SetActive(true);
        }

        if (npcLocation.playerInStudy)
        {
            studyDark.SetActive(false);
        }
        else
        {
            studyDark.SetActive(true);
        }

        if (npcLocation.playerInHallway)
        {
            hallwayDark.SetActive(false);
        }
        else
        {
            hallwayDark.SetActive(true);
        }








    }
}
