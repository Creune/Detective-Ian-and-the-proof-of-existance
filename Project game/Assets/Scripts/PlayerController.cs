using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float speed=5f;
    public NPCLocationController locationController;
    public bool shot;

    private void Start()
    {
        shot = false;
    }
    void FixedUpdate()
    {
        movement();
    }

    public void movement() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        LocationTrackerEnter(collider);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        LocationTrackerExit(collision);
    }

    public void LocationTrackerEnter(Collider2D collider) {
        switch (collider.gameObject.name) {
            case "Lobby":
                locationController.playerInLobby = true;
                break;
            case "GuestRoom1":
                locationController.playerInGuestRoom1=true;
                break;
            case "GuestRoom2":
                locationController.playerInGuestRoom2 = true;
                break;
            case "GuestRoom3":
                locationController.playerInGuestRoom3 = true;
                break;
            case "GuestRoom4":
                locationController.playerInGuestRoom4 = true;
                break;
            case "DiningRoom":
                locationController.playerInDiningRoom = true;
                break;
            case "Kitchen":
                locationController.playerInKitchen = true;
                break;
            case "Garage":
                locationController.playerInGarage = true;
                break;
            case "Pantry":
                locationController.playerInPantry = true;
                break;
            case "MusicRoom":
                locationController.playerInMusicRoom = true;
                break;
            case "GameRoom":
                locationController.playerInGameRoom = true;
                break;
            case "Storage":
                locationController.playerInStorage = true;
                break;
            case "WarRoom":
                locationController.playerInWarRoom = true;
                break;
            case "Utility":
                locationController.playerInUtility = true;
                break;
            case "Bathroom":
                locationController.playerInBathroom = true;
                break;
            case "MasterBedroom":
                locationController.playerInMasterBedroom = true;
                break;
            case "Library":
                locationController.playerInLibrary = true;
                break;
            case "Study":
                locationController.playerInStudy = true;
                break;
            case "Lounge":
                locationController.playerInLounge = true;
                break;
            case "MasterBathroom":
                locationController.playerInMasterBathroom = true;
                break;
            case "Office":
                locationController.playerInOffice = true;
                break;
            case "TrophyRoom":
                locationController.playerInTrophyRoom = true;
                break;
            case "Hallway":
                locationController.playerInHallway = true;
                break;
        }
    }

    public void LocationTrackerExit(Collider2D collider) {
        switch (collider.gameObject.name)
        {
            case "Lobby":
                locationController.playerInLobby = false;
                break;
            case "GuestRoom1":
                locationController.playerInGuestRoom1 = false;
                break;
            case "GuestRoom2":
                locationController.playerInGuestRoom2 = false;
                break;
            case "GuestRoom3":
                locationController.playerInGuestRoom3 = false;
                break;
            case "GuestRoom4":
                locationController.playerInGuestRoom4 = false;
                break;
            case "DiningRoom":
                locationController.playerInDiningRoom = false;
                break;
            case "Kitchen":
                locationController.playerInKitchen = false;
                break;
            case "Garage":
                locationController.playerInGarage = false;
                break;
            case "Pantry":
                locationController.playerInPantry = false;
                break;
            case "MusicRoom":
                locationController.playerInMusicRoom = false;
                break;
            case "GameRoom":
                locationController.playerInGameRoom = false;
                break;
            case "Storage":
                locationController.playerInStorage = false;
                break;
            case "WarRoom":
                locationController.playerInWarRoom = false;
                break;
            case "Utility":
                locationController.playerInUtility = false;
                break;
            case "Bathroom":
                locationController.playerInBathroom = false;
                break;
            case "MasterBedroom":
                locationController.playerInMasterBedroom = false;
                break;
            case "Library":
                locationController.playerInLibrary = false;
                break;
            case "Study":
                locationController.playerInStudy = false;
                break;
            case "Lounge":
                locationController.playerInLounge = false;
                break;
            case "MasterBathroom":
                locationController.playerInMasterBathroom = false;
                break;
            case "Office":
                locationController.playerInOffice = false;
                break;
            case "TrophyRoom":
                locationController.playerInTrophyRoom = false;
                break;
            case "Hallway":
                locationController.playerInHallway = false;
                break;
        }
    }

}
