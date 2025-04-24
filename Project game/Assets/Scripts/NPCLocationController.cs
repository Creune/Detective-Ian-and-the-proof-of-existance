using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCLocationController : MonoBehaviour
{
    public List <GameObject> SuspectsInLobby= new List<GameObject>();
    public List<GameObject> SuspectsInGuestRoom1 = new List<GameObject>(); 
    public List<GameObject> SuspectsInGuestRoom2 = new List<GameObject>(); 
    public List<GameObject> SuspectsInGuestRoom3 = new List<GameObject>();
    public List<GameObject> SuspectsInGuestRoom4 = new List<GameObject>();
    public List<GameObject> SuspectsInDiningRoom = new List<GameObject>(); 
    public List<GameObject> SuspectsInKitchen = new List<GameObject>(); 
    public List<GameObject> SuspectsInGarage = new List<GameObject>(); 
    public List<GameObject> SuspectsInPantry = new List<GameObject>(); 
    public List<GameObject> SuspectsInMusicRoom = new List<GameObject>(); 
    public List<GameObject> SuspectsInGameRoom = new List<GameObject>();
    public List<GameObject> SuspectsInStorage = new List<GameObject>();
    public List<GameObject> SuspectsInWarRoom = new List<GameObject>();
    public List<GameObject> SuspectsInUtility = new List<GameObject>();
    public List<GameObject> SuspectsInBathroom = new List<GameObject>();
    public List<GameObject> SuspectsInMasterBedroom = new List<GameObject>();
    public List<GameObject> SuspectsInLibrary = new List<GameObject>();
    public List<GameObject> SuspectsInStudy = new List<GameObject>();
    public List<GameObject> SuspectsInLounge = new List<GameObject>();
    public List<GameObject> SuspectsInMasterBathroom = new List<GameObject>();
    public List<GameObject> SuspectsInTrophyRoom = new List<GameObject>();
    public List<GameObject> SuspectsInOffice = new List<GameObject>();

    

    public bool playerInLobby;
    public bool playerInGuestRoom1;
    public bool playerInGuestRoom2;
    public bool playerInGuestRoom3;
    public bool playerInGuestRoom4;
    public bool playerInDiningRoom;
    public bool playerInKitchen;
    public bool playerInGarage;
    public bool playerInPantry;
    public bool playerInMusicRoom;
    public bool playerInGameRoom;
    public bool playerInStorage;
    public bool playerInWarRoom;
    public bool playerInUtility;
    public bool playerInBathroom;
    public bool playerInMasterBedroom;
    public bool playerInLibrary;
    public bool playerInStudy;
    public bool playerInLounge;
    public bool playerInMasterBathroom;
    public bool playerInOffice;
    public bool playerInTrophyRoom;
    public bool playerInHallway;

    public bool murdererInLobby;
    public bool murdererInGuestRoom1;
    public bool murdererInGuestRoom2;
    public bool murdererInGuestRoom3;
    public bool murdererInGuestRoom4;
    public bool murdererInDiningRoom;
    public bool murdererInKitchen;
    public bool murdererInGarage;
    public bool murdererInPantry;
    public bool murdererInMusicRoom;
    public bool murdererInGameRoom;
    public bool murdererInStorage;
    public bool murdererInWarRoom;
    public bool murdererInUtility;
    public bool murdererInBathroom;
    public bool murdererInMasterBedroom;
    public bool murdererInLibrary;
    public bool murdererInStudy;
    public bool murdererInLounge;
    public bool murdererInMasterBathroom;
    public bool murdererInOffice;
    public bool murdererInTrophyRoom;

    public bool bodyInLobby;
    public bool bodyInGuestRoom1;
    public bool bodyInGuestRoom2;
    public bool bodyInGuestRoom3;
    public bool bodyInGuestRoom4;
    public bool bodyInDiningRoom;
    public bool bodyInKitchen;
    public bool bodyInGarage;
    public bool bodyInPantry;
    public bool bodyInMusicRoom;
    public bool bodyInGameRoom;
    public bool bodyInStorage;
    public bool bodyInWarRoom;
    public bool bodyInUtility;
    public bool bodyInBathroom;
    public bool bodyInMasterBedroom;
    public bool bodyInLibrary;
    public bool bodyInStudy;
    public bool bodyInLounge;
    public bool bodyInMasterBathroom;
    public bool bodyInOffice;
    public bool bodyInTrophyRoom;

    void Start()
    {
        

        playerInLobby = true;
        playerInGuestRoom1 = false;
        playerInGuestRoom2 = false;
        playerInGuestRoom3 = false;
        playerInGuestRoom4 = false;
        playerInDiningRoom = false;
        playerInKitchen = false;
        playerInGarage = false;
        playerInPantry = false;
        playerInMusicRoom = false;
        playerInGameRoom = false;
        playerInStorage = false;
        playerInWarRoom = false;
        playerInUtility = false;
        playerInBathroom = false;
        playerInMasterBedroom = false;
        playerInLibrary = false;
        playerInStudy = false;
        playerInLounge = false;
        playerInMasterBathroom = false;
        playerInOffice = false;
        playerInTrophyRoom = false;
        playerInHallway = false;

        murdererInLobby = true;
        murdererInGuestRoom1 = false;
        murdererInGuestRoom2 = false;
        murdererInGuestRoom3 = false;
        murdererInGuestRoom4 = false;
        murdererInDiningRoom = false;
        murdererInKitchen = false;
        murdererInGarage = false;
        murdererInPantry = false;
        murdererInMusicRoom = false;
        murdererInGameRoom = false;
        murdererInStorage = false;
        murdererInWarRoom = false;
        murdererInUtility = false;
        murdererInBathroom = false;
        murdererInMasterBedroom = false;
        murdererInLibrary = false;
        murdererInStudy = false;
        murdererInLounge = false;
        murdererInMasterBathroom = false;
        murdererInOffice = false;
        murdererInTrophyRoom = false;

        bodyInLobby = false;
        bodyInGuestRoom1 = false;
        bodyInGuestRoom2 = false;
        bodyInGuestRoom3 = false;
        bodyInGuestRoom4 = false;
        bodyInDiningRoom = false;
        bodyInKitchen = false;
        bodyInGarage = false;
        bodyInPantry = false;
        bodyInMusicRoom = false;
        bodyInGameRoom = false;
        bodyInStorage = false;
        bodyInWarRoom = false;
        bodyInUtility = false;
        bodyInBathroom = false;
        bodyInMasterBedroom = false;
        bodyInLibrary = false;
        bodyInStudy = false;
        bodyInLounge = false;
        bodyInMasterBathroom = false;
        bodyInOffice = false;
        bodyInTrophyRoom = false;
    }
}
