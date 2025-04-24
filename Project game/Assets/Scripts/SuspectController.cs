using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SuspectController : MonoBehaviour
{
    Transform target;
    [SerializeField] Transform lobby;
    [SerializeField] Transform guestRoom1;
    [SerializeField] Transform guestRoom2;
    [SerializeField] Transform guestRoom3;
    [SerializeField] Transform guestRoom4;
    [SerializeField] Transform diningRoom;
    [SerializeField] Transform kitchen;
    [SerializeField] Transform garage;
    [SerializeField] Transform pantry;
    [SerializeField] Transform musicRoom;
    [SerializeField] Transform gameRoom;
    [SerializeField] Transform storageRoom;
    [SerializeField] Transform warRoom;
    [SerializeField] Transform utility;
    [SerializeField] Transform bathroom;
    [SerializeField] Transform mBedroom;
    [SerializeField] Transform library;
    [SerializeField] Transform study;
    [SerializeField] Transform lounge;
    [SerializeField] Transform mBathroom;
    [SerializeField] Transform office;
    [SerializeField] Transform trophyRoom;

    NavMeshAgent agent;
    public NPCLocationController locationController;
    void Start()
    {
        int radomSpawn = Random.Range(0,3);
        target = lobby.GetChild(radomSpawn);
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

        if (!this.GetComponent<ScriptController>().kill)
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
            int random = Random.Range(0, 22);
            int goals;
            int waitTime = Random.Range(5, 10);
            yield return new WaitForSecondsRealtime(waitTime);
            switch (random)
            {
                case 0:
                    
                    goals = Random.Range(0, lobby.transform.childCount);
                    target = lobby.transform.GetChild(goals);
                    break;
                case 1:
                    
                    goals = Random.Range(0, guestRoom1.transform.childCount);
                    target = guestRoom1.transform.GetChild(goals);
                    break;
                case 2:
                    
                    goals = Random.Range(0, guestRoom2.transform.childCount);
                    target = guestRoom2.transform.GetChild(goals);
                    break;
                case 3:
                    
                    goals = Random.Range(0, guestRoom3.transform.childCount);
                    target = guestRoom3.transform.GetChild(goals);
                    break;
                case 4:
                    
                    goals = Random.Range(0, guestRoom4.transform.childCount);
                    target = guestRoom4.transform.GetChild(goals);
                    break;
                case 5:
                    
                    goals = Random.Range(0, diningRoom.transform.childCount);
                    target = diningRoom.transform.GetChild(goals);
                    break;
                case 6:
                    
                    goals = Random.Range(0, kitchen.transform.childCount);
                    target = kitchen.transform.GetChild(goals);
                    break;
                case 7:
                    
                    goals = Random.Range(0, garage.transform.childCount);
                    target = garage.transform.GetChild(goals);
                    break;
                case 8:
                    
                    goals = Random.Range(0, pantry.transform.childCount);
                    target = pantry.transform.GetChild(goals);
                    break;
                case 9:
                    
                    goals = Random.Range(0, musicRoom.transform.childCount);
                    target = musicRoom.transform.GetChild(goals);
                    break;
                case 10:
                    
                    goals = Random.Range(0, gameRoom.transform.childCount);
                    target = gameRoom.transform.GetChild(goals);
                    break;
                case 11:
                    
                    goals = Random.Range(0, storageRoom.transform.childCount);
                    target = storageRoom.transform.GetChild(goals);
                    break;
                case 12:
                    
                    goals = Random.Range(0, warRoom.transform.childCount);
                    target = warRoom.transform.GetChild(goals);
                    break;
                case 13:
                    
                    goals = Random.Range(0, utility.transform.childCount);
                    target = utility.transform.GetChild(goals);
                    break;
                case 14:
                    
                    goals = Random.Range(0, bathroom.transform.childCount);
                    target = bathroom.transform.GetChild(goals);
                    break;
                case 15:
                    
                    goals = Random.Range(0, mBedroom.transform.childCount);
                    target = mBedroom.transform.GetChild(goals);
                    break;
                case 16:
                    
                    goals = Random.Range(0, library.transform.childCount);
                    target = library.transform.GetChild(goals);
                    break;
                case 17:
                    
                    goals = Random.Range(0, study.transform.childCount);
                    target = study.transform.GetChild(goals);
                    break;
                case 18:
                    
                    goals = Random.Range(0, lounge.transform.childCount);
                    target = lounge.transform.GetChild(goals);
                    break;
                case 19:
                    
                    goals = Random.Range(0, mBathroom.transform.childCount);
                    target = mBathroom.transform.GetChild(goals);
                    break;
                case 20:
                    
                    goals = Random.Range(0, office.transform.childCount);
                    target = office.transform.GetChild(goals);
                    break;
                case 21:
                    
                    goals = Random.Range(0, trophyRoom.transform.childCount);
                    target = trophyRoom.transform.GetChild(goals);
                    break;
                default:
                    
                    goals = Random.Range(0, lobby.transform.childCount);
                    target = lobby.transform.GetChild(goals);
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!this.GetComponent<ScriptController>().kill)
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
            Debug.Log("Someone has died at "+roomName+" - "+gameObject.name);
        }
    }
}
