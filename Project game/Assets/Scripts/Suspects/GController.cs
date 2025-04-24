using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class GController : MonoBehaviour
{
    Transform target;
    [SerializeField] Transform lobby;
    [SerializeField] Transform guestRoom4;
    [SerializeField] Transform kitchen;
    [SerializeField] Transform garage;
    [SerializeField] Transform pantry;
    [SerializeField] Transform musicRoom;
    [SerializeField] Transform gameRoom;
    [SerializeField] Transform storageRoom;
    [SerializeField] Transform warRoom;
    [SerializeField] Transform utility;
    [SerializeField] Transform bathroom;
    [SerializeField] Transform library;
    [SerializeField] Transform study;
    [SerializeField] Transform lounge;
    [SerializeField] Transform office;

    NavMeshAgent agent;
    public NPCLocationController locationController;
    public PlayerUIController playerUI;
    void Start()
    {
        target = lobby.GetChild(3).GetChild(6);
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        if (gameObject.tag == "Suspect")
        {

            StartCoroutine(SetTarget(collider));

            if (collider.tag == "RoomTrigger")
            {
                EnterRoom(collider);
            }
        }

        
    }
    IEnumerator SetTarget(Collider2D collider) {
        if (collider.tag == "GoalNode" && (collider.gameObject.name==target.name))
        {
            int random = Random.Range(0, 34);
            int waitTime = Random.Range(5, 10);
            yield return new WaitForSecondsRealtime(waitTime);
            switch (random)
            {
                case 0:
                    target = lobby.transform.GetChild(0);
                    break;
                case 1:
                    target = lobby.transform.GetChild(1);
                    break;
                case 2:
                    target = lobby.transform.GetChild(2);
                    break;
                case 3:
                    target = guestRoom4.transform.GetChild(0);
                    break;
                case 4:
                    target = guestRoom4.transform.GetChild(2);
                    break;
                case 5:
                    target = kitchen.transform.GetChild(1);
                    break;
                case 6:
                    target = kitchen.transform.GetChild(2);
                    break;
                case 7:
                    target = garage.transform.GetChild(0);
                    break;
                case 8:
                    target = garage.transform.GetChild(1);
                    break;
                case 9:
                    target = pantry.transform.GetChild(2);
                    break;
                case 10:
                    target = pantry.transform.GetChild(3);
                    break;
                case 11:
                    target = musicRoom.transform.GetChild(0);
                    break;
                case 12:
                    target = musicRoom.transform.GetChild(1);
                    break;
                case 13:
                    target = musicRoom.transform.GetChild(2);
                    break;
                case 14:
                    target = musicRoom.transform.GetChild(3);
                    break;
                case 15:
                    target = gameRoom.transform.GetChild(0);
                    break;
                case 16:
                    target = gameRoom.transform.GetChild(1);
                    break;
                case 17:
                    target = storageRoom.transform.GetChild(1);
                    break;
                case 18:
                    target = storageRoom.transform.GetChild(2);
                    break;
                case 19:
                    target = warRoom.transform.GetChild(2);
                    break;
                case 20:
                    target = bathroom.transform.GetChild(0);
                    break;
                case 21:
                    target = bathroom.transform.GetChild(1);
                    break;
                case 22:
                    target = bathroom.transform.GetChild(2);
                    break;
                case 23:
                    target = bathroom.transform.GetChild(3);
                    break;
                case 24:
                    target = library.transform.GetChild(1);
                    break;
                case 25:
                    target = bathroom.transform.GetChild(2);
                    break;
                case 26:
                    target = study.transform.GetChild(0);
                    break;
                case 27:
                    target = study.transform.GetChild(1);
                    break;
                case 28:
                    target = study.transform.GetChild(2);
                    break;
                case 29:
                    target = office.transform.GetChild(0);
                    break;
                case 30:
                    target = office.transform.GetChild(1);
                    break;
                case 31:
                    target = office.transform.GetChild(2);
                    break;
                case 32:
                    target = lounge.transform.GetChild(0);
                    break;
                case 33:
                    target = lounge.transform.GetChild(2);
                    break;
                default:
                    target = lobby.GetChild(3).GetChild(6);
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.tag == "Suspect")
        {
            if (collision.tag == "RoomTrigger")
            {
                ExitRoom(collision);
            }
        }
    }

    public void ExitRoom(Collider2D collision) {

        string roomName = collision.gameObject.name;
        switch (roomName)
        {
            case "Lobby":
                locationController.SuspectsInLobby.Remove(gameObject);
                break;
            case "GuestRoom1":
                locationController.SuspectsInGuestRoom1.Remove(gameObject);
                break;
            case "GuestRoom2":
                locationController.SuspectsInGuestRoom2.Remove(gameObject);
                break;
            case "GuestRoom3":
                locationController.SuspectsInGuestRoom3.Remove(gameObject);
                break;
            case "GuestRoom4":
                locationController.SuspectsInGuestRoom4.Remove(gameObject);
                break;
            case "DiningRoom":
                locationController.SuspectsInDiningRoom.Remove(gameObject);
                break;
            case "Kitchen":
                locationController.SuspectsInKitchen.Remove(gameObject);
                break;
            case "Garage":
                locationController.SuspectsInGarage.Remove(gameObject);
                break;
            case "Pantry":
                locationController.SuspectsInPantry.Remove(gameObject);
                break;
            case "MusicRoom":
                locationController.SuspectsInMusicRoom.Remove(gameObject);
                break;
            case "GameRoom":
                locationController.SuspectsInGameRoom.Remove(gameObject);
                break;
            case "Storage":
                locationController.SuspectsInStorage.Remove(gameObject);
                break;
            case "WarRoom":
                locationController.SuspectsInWarRoom.Remove(gameObject);
                break;
            case "Utility":
                locationController.SuspectsInUtility.Remove(gameObject);
                break;
            case "Bathroom":
                locationController.SuspectsInBathroom.Remove(gameObject);
                break;
            case "MasterBedroom":
                locationController.SuspectsInMasterBedroom.Remove(gameObject);
                break;
            case "Library":
                locationController.SuspectsInLibrary.Remove(gameObject);
                break;
            case "Study":
                locationController.SuspectsInStudy.Remove(gameObject);
                break;
            case "Lounge":
                locationController.SuspectsInLounge.Remove(gameObject);
                break;
            case "MasterBathroom":
                locationController.SuspectsInMasterBathroom.Remove(gameObject);
                break;
            case "Office":
                locationController.SuspectsInOffice.Remove(gameObject);
                break;
            case "TrophyRoom":
                locationController.SuspectsInTrophyRoom.Remove(gameObject);
                break;
        }
    }

    public void EnterRoom(Collider2D collision)
    {
        string roomName = collision.gameObject.name;
        switch (roomName)
        {
            case "Lobby":
                locationController.SuspectsInLobby.Add(gameObject);
                ReportBody(roomName, locationController.bodyInLobby);
                break;
            case "GuestRoom1":
                locationController.SuspectsInGuestRoom1.Add(gameObject);
                ReportBody(roomName, locationController.bodyInGuestRoom1);
                break;
            case "GuestRoom2":
                locationController.SuspectsInGuestRoom2.Add(gameObject);
                ReportBody(roomName, locationController.bodyInGuestRoom2);
                break;
            case "GuestRoom3":
                locationController.SuspectsInGuestRoom3.Add(gameObject);
                ReportBody(roomName, locationController.bodyInGuestRoom3);
                break;
            case "GuestRoom4":
                locationController.SuspectsInGuestRoom4.Add(gameObject);
                ReportBody(roomName, locationController.bodyInGuestRoom4);
                break;
            case "DiningRoom":
                locationController.SuspectsInDiningRoom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInDiningRoom);
                break;
            case "Kitchen":
                locationController.SuspectsInKitchen.Add(gameObject);
                ReportBody(roomName, locationController.bodyInKitchen);
                break;
            case "Garage":
                locationController.SuspectsInGarage.Add(gameObject);
                ReportBody(roomName, locationController.bodyInGarage);
                break;
            case "Pantry":
                locationController.SuspectsInPantry.Add(gameObject);
                ReportBody(roomName, locationController.bodyInPantry);
                break;
            case "MusicRoom":
                locationController.SuspectsInMusicRoom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInMusicRoom);
                break;
            case "GameRoom":
                locationController.SuspectsInGameRoom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInGameRoom);
                break;
            case "Storage":
                locationController.SuspectsInStorage.Add(gameObject);
                ReportBody(roomName, locationController.bodyInStorage);
                break;
            case "WarRoom":
                locationController.SuspectsInWarRoom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInWarRoom);
                break;
            case "Utility":
                locationController.SuspectsInUtility.Add(gameObject);
                ReportBody(roomName, locationController.bodyInUtility);
                break;
            case "Bathroom":
                locationController.SuspectsInBathroom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInBathroom);
                break;
            case "MasterBedroom":
                locationController.SuspectsInMasterBedroom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInMasterBedroom);
                break;
            case "Library":
                locationController.SuspectsInLibrary.Add(gameObject);
                ReportBody(roomName, locationController.bodyInLibrary);
                break;
            case "Study":
                locationController.SuspectsInStudy.Add(gameObject);
                ReportBody(roomName, locationController.bodyInStudy);
                break;
            case "Lounge":
                locationController.SuspectsInLounge.Add(gameObject);
                ReportBody(roomName, locationController.bodyInLounge);
                break;
            case "MasterBathroom":
                locationController.SuspectsInMasterBathroom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInMasterBathroom);
                break;
            case "Office":
                locationController.SuspectsInOffice.Add(gameObject);
                ReportBody(roomName, locationController.bodyInOffice);
                break;
            case "TrophyRoom":
                locationController.SuspectsInTrophyRoom.Add(gameObject);
                ReportBody(roomName, locationController.bodyInTrophyRoom);
                break;
        }
    }

    public void ReportBody(string roomName, bool roomHasBody) {
        if (roomHasBody) {
            playerUI.popupTextList.Add("Someone has died at "+roomName+" - "+gameObject.name);
        }
    }
}
