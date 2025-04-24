
using UnityEngine;

public class BodyController : MonoBehaviour
{

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

    public RoleCall rolecall;

    public Sprite img;

    public NPCLocationController locationController;
    public PlayerUIController playerUI;

    public GameObject body;

    public bool bodyFound;
    public string killedby;
    public int minuteOfDeath=-2;
    public int secondOfDeath;
    bool timed;
    private void Start()
    {
        this.GetComponent<Animator>().enabled=false;
        if (this.GetComponent<TriangleAnim>()!=null) {
            this.GetComponent<TriangleAnim>().enabled = false;
        }

        this.GetComponent<SpriteRenderer>().sprite = img;
        timed = false;
        bodyFound = false;
       
    }

    private void Update()
    {
        if (GetComponent<BodyController>().enabled && !timed) {
            minuteOfDeath = rolecall.realMinutes;
            secondOfDeath = rolecall.realSeconds;
            timed=true;
        }
    }
    private void OnTriggerStay2D(Collider2D collider)
    {

        if (!bodyFound && gameObject.tag=="KilledSuspect")
        {
            LocateBody(collider);
        }
    }

    public void LocateBody(Collider2D collider)
    {
        string roomName = collider.gameObject.name;
        
        switch (roomName)
        {
            case "Lobby":
                locationController.bodyInLobby = true;
                locationController.SuspectsInLobby.Remove(gameObject);
                break;
            case "GuestRoom1":
                locationController.bodyInGuestRoom1 = true;
                locationController.SuspectsInGuestRoom1.Remove(gameObject);
                break;
            case "GuestRoom2":
                locationController.bodyInGuestRoom2 = true;
                locationController.SuspectsInGuestRoom2.Remove(gameObject);
                break;
            case "GuestRoom3":
                locationController.bodyInGuestRoom3 = true;
                locationController.SuspectsInGuestRoom3.Remove(gameObject);
                break;
            case "GuestRoom4":
                locationController.bodyInGuestRoom4 = true;
                locationController.SuspectsInGuestRoom4.Remove(gameObject);
                break;
            case "DiningRoom":
                locationController.bodyInDiningRoom = true;
                locationController.SuspectsInDiningRoom.Remove(gameObject);
                break;
            case "Kitchen":
                locationController.bodyInKitchen = true;
                locationController.SuspectsInKitchen.Remove(gameObject);
                break;
            case "Garage":
                locationController.bodyInGarage = true;
                locationController.SuspectsInGarage.Remove(gameObject);
                break;
            case "Pantry":
                locationController.bodyInPantry = true;
                locationController.SuspectsInPantry.Remove(gameObject);
                break;
            case "MusicRoom":
                locationController.bodyInMusicRoom = true;
                locationController.SuspectsInMusicRoom.Remove(gameObject);
                break;
            case "GameRoom":
                locationController.bodyInGameRoom = true;
                locationController.SuspectsInGameRoom.Remove(gameObject);
                break;
            case "Storage":
                locationController.bodyInStorage = true;
                locationController.SuspectsInStorage.Remove(gameObject);
                break;
            case "WarRoom":
                locationController.bodyInWarRoom = true;
                locationController.SuspectsInWarRoom.Remove(gameObject);
                break;
            case "Utility":
                locationController.bodyInUtility = true;
                locationController.SuspectsInUtility.Remove(gameObject);
                break;
            case "Bathroom":
                locationController.bodyInBathroom = true;
                locationController.SuspectsInBathroom.Remove(gameObject);
                break;
            case "MasterBedroom":
                locationController.bodyInMasterBedroom = true;
                locationController.SuspectsInMasterBedroom.Remove(gameObject);
                break;
            case "Library":
                locationController.bodyInLibrary = true;
                locationController.SuspectsInLibrary.Remove(gameObject);
                break;
            case "Study":
                locationController.bodyInStudy = true;
                locationController.SuspectsInStudy.Remove(gameObject);
                break;
            case "Lounge":
                locationController.bodyInLounge = true;
                locationController.SuspectsInLounge.Remove(gameObject);
                break;
            case "MasterBathroom":
                locationController.bodyInMasterBathroom = true;
                locationController.SuspectsInMasterBathroom.Remove(gameObject);
                break;
            case "Office":
                locationController.bodyInOffice = true;
                locationController.SuspectsInOffice.Remove(gameObject);
                break;
            case "TrophyRoom":
                locationController.bodyInTrophyRoom = true;
                locationController.SuspectsInTrophyRoom.Remove(gameObject);
                break;
        }
    }

    public void OnMouseDown()
    {
        if (gameObject.GetComponent<BodyController>().enabled&&!bodyFound)
        {
            playerUI.popupTextList.Add(gameObject.name+" died at " + minuteOfDeath + ":" + secondOfDeath + " of " + killedby);
            bodyFound = true;
        }
    }
}
