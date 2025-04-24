using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MurderController : MonoBehaviour
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

    public bool hasWeapon;
    public string weaponName;
    Dictionary <Transform, string> weaponLocations=new Dictionary<Transform, string>(); 
    void Start()
    {
        switch (gameObject.name) {
            case "Alfred":
                target = lobby.GetChild(3).GetChild(0);
                break;
            case "Brad":
                target = lobby.GetChild(3).GetChild(1);
                break;
            case "Chris":
                target = lobby.GetChild(3).GetChild(2);
                break;
            case "David":
                target = lobby.GetChild(3).GetChild(3);
                break;
            case "Evan":
                target = lobby.GetChild(3).GetChild(4);
                break;
            case "Freddy":
                target = lobby.GetChild(3).GetChild(5);
                break;
            case "George":
                target = lobby.GetChild(3).GetChild(6);
                break;
            default:
                target = lobby.GetChild(3).GetChild(7);
                break;
        }
        
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        hasWeapon = false;
        weaponName = "";

        weaponLocations.Add(guestRoom1.GetChild(1), "Baseball bat");
        weaponLocations.Add(guestRoom2.GetChild(2), "Coathanger");
        weaponLocations.Add(guestRoom3.GetChild(0), "Desklamp");
        weaponLocations.Add(diningRoom.GetChild(0), "Poison");
        weaponLocations.Add(kitchen.GetChild(0), "Knife");
        weaponLocations.Add(garage.GetChild(2), "Crowbar");
        weaponLocations.Add(musicRoom.GetChild(3), "Violin string");
        weaponLocations.Add(warRoom.GetChild(1), "Dagger");
        weaponLocations.Add(utility.GetChild(0), "Boxcutter");
        weaponLocations.Add(library.GetChild(1), "Hardcover book");
        weaponLocations.Add(study.GetChild(2), "Metal ruler");
        weaponLocations.Add(lounge.GetChild(1), "Plant pot");
        weaponLocations.Add(office.GetChild(1), "Stapler");
        weaponLocations.Add(trophyRoom.GetChild(3), "Rifle");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        if (gameObject.tag=="Untagged")
        {

            StartCoroutine(SetTarget(collider));

            if (collider.tag == "RoomTrigger")
            {
                EnterRoom(collider);
            }
            else if (collider.tag == "GoalNode" && !hasWeapon) { 
                PickWeapon(collider);
            }
        }

    }
    IEnumerator SetTarget(Collider2D collider)
    {
        if (collider.tag == "GoalNode" && ( collider.gameObject.name == target.name))
        {
            int random = Random.Range(0, 22);
            int goals;
            int waitTime = Random.Range(5, 10);
            yield return new WaitForSecondsRealtime(waitTime);
            switch (random)
            {
                case 0:
                    
                    goals = Random.Range(0, lobby.transform.childCount-1);
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
        if (gameObject.tag=="Untagged")
        {

            if (collision.tag == "RoomTrigger")
            {
                ExitRoom(collision);
            }
        }
    }

    public void ExitRoom(Collider2D collision)
    {

        string roomName = collision.gameObject.name;
        switch (roomName)
        {
            case "Lobby":
                locationController.murdererInLobby=false;
                break;
            case "GuestRoom1":
                locationController.murdererInGuestRoom1=false;
                break;
            case "GuestRoom2":
                locationController.murdererInGuestRoom2=false;
                break;
            case "GuestRoom3":
                locationController.murdererInGuestRoom3=false;
                break;
            case "GuestRoom4":
                locationController.murdererInGuestRoom4=false;
                break;
            case "DiningRoom":
                locationController.murdererInDiningRoom=false;
                break;
            case "Kitchen":
                locationController.murdererInKitchen=false;
                break;
            case "Garage":
                locationController.murdererInGarage=false;
                break;
            case "Pantry":
                locationController.murdererInPantry=false;
                break;
            case "MusicRoom":
                locationController.murdererInMusicRoom=false;
                break;
            case "GameRoom":
                locationController.murdererInGameRoom=false;
                break;
            case "Storage":
                locationController.murdererInStorage=false;
                break;
            case "WarRoom":
                locationController.murdererInWarRoom=false;
                break;
            case "Utility":
                locationController.murdererInUtility=false;
                break;
            case "Bathroom":
                locationController.murdererInBathroom=false;
                break;
            case "MasterBedroom":
                locationController.murdererInMasterBedroom=false;
                break;
            case "Library":
                locationController.murdererInLibrary=false;
                break;
            case "Study":
                locationController.murdererInStudy=false;
                break;
            case "Lounge":
                locationController.murdererInLounge=false;
                break;
            case "MasterBathroom":
                locationController.murdererInMasterBathroom=false;
                break;
            case "Office":
                locationController.murdererInOffice=false;
                break;
            case "TrophyRoom":
                locationController.murdererInTrophyRoom=false;
                break;
        }
    }

    public void EnterRoom(Collider2D collision)
    {
        string roomName = collision.gameObject.name;
        switch (roomName)
        {
            case "Lobby":
                locationController.murdererInLobby=true;
                KillCheck(locationController.SuspectsInLobby, locationController.playerInLobby, collision);
                break;
            case "GuestRoom1":
                locationController.murdererInGuestRoom1=true;
                KillCheck(locationController.SuspectsInGuestRoom1, locationController.playerInGuestRoom1, collision);
                break;
            case "GuestRoom2":
                locationController.murdererInGuestRoom2=true;
                KillCheck(locationController.SuspectsInGuestRoom2, locationController.playerInGuestRoom2, collision);
                break;
            case "GuestRoom3":
                locationController.murdererInGuestRoom3=true;
                KillCheck(locationController.SuspectsInGuestRoom3, locationController.playerInGuestRoom3, collision);
                break;
            case "GuestRoom4":
                locationController.murdererInGuestRoom4=true;
                KillCheck(locationController.SuspectsInGuestRoom4, locationController.playerInGuestRoom4, collision);
                break;
            case "DiningRoom":
                locationController.murdererInDiningRoom=true;
                KillCheck(locationController.SuspectsInDiningRoom, locationController.playerInDiningRoom, collision);
                break;
            case "Kitchen":
                locationController.murdererInKitchen=true;
                KillCheck(locationController.SuspectsInKitchen, locationController.playerInKitchen, collision);
                break;
            case "Garage":
                locationController.murdererInGarage=true;
                KillCheck(locationController.SuspectsInGarage, locationController.playerInGarage, collision);
                break;
            case "Pantry":
                locationController.murdererInPantry=true;
                KillCheck(locationController.SuspectsInPantry, locationController.playerInPantry, collision);
                break;
            case "MusicRoom":
                locationController.murdererInMusicRoom=true;
                KillCheck(locationController.SuspectsInMusicRoom, locationController.playerInMusicRoom, collision);
                break;
            case "GameRoom":
                locationController.murdererInGameRoom=true;
                KillCheck(locationController.SuspectsInGameRoom, locationController.playerInGameRoom, collision);
                break;
            case "Storage":
                locationController.murdererInStorage=true;
                KillCheck(locationController.SuspectsInStorage, locationController.playerInStorage, collision);
                break;
            case "WarRoom":
                locationController.murdererInWarRoom=true;
                KillCheck(locationController.SuspectsInWarRoom, locationController.playerInWarRoom, collision);
                break;
            case "Utility":
                locationController.murdererInUtility=true;
                KillCheck(locationController.SuspectsInUtility, locationController.playerInUtility, collision);
                break;
            case "Bathroom":
                locationController.murdererInBathroom=true;
                KillCheck(locationController.SuspectsInBathroom, locationController.playerInBathroom, collision);
                break;
            case "MasterBedroom":
                locationController.murdererInMasterBedroom=true;
                KillCheck(locationController.SuspectsInMasterBedroom, locationController.playerInMasterBedroom, collision);
                break;
            case "Library":
                locationController.murdererInLibrary=true;
                KillCheck(locationController.SuspectsInLibrary, locationController.playerInLibrary, collision);
                break;
            case "Study":
                locationController.murdererInStudy=true;
                KillCheck(locationController.SuspectsInStudy, locationController.playerInStudy, collision);
                break;
            case "Lounge":
                locationController.murdererInLounge=true;
                KillCheck(locationController.SuspectsInLounge, locationController.playerInLounge, collision);
                break;
            case "MasterBathroom":
                locationController.murdererInMasterBathroom=true;
                KillCheck(locationController.SuspectsInMasterBathroom, locationController.playerInMasterBathroom, collision);
                break;
            case "Office":
                locationController.murdererInOffice=true;
                KillCheck(locationController.SuspectsInOffice, locationController.playerInOffice, collision);
                break;
            case "TrophyRoom":
                locationController.murdererInTrophyRoom=true;
                KillCheck(locationController.SuspectsInTrophyRoom, locationController.playerInTrophyRoom, collision);
                break;
        }
    }

    public void KillCheck(List<GameObject> suspectNumber, bool playerInRoom, Collider2D collider) {
        if (hasWeapon && suspectNumber.Count() == 1 && !playerInRoom)
        {
            suspectNumber[0].GetComponent<BodyController>().killedby = weaponName;
            suspectNumber[0].tag = "KilledSuspect";
            hasWeapon = false;
            weaponName = "";
        }

       
    }
    public void PickWeapon(Collider2D collider)
    {
        if (target.name==collider.name && !hasWeapon) {
            foreach (KeyValuePair<Transform, string> location in weaponLocations) {
                if (location.Key.name==collider.name) {
                    hasWeapon = true;
                    weaponName = location.Value;
                }
            }

        }
    }
}
