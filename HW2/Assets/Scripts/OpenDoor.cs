using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject KeyWithDoor;
    public GameObject OpenDoorText;
    
    void Start(){
        KeyWithDoor.SetActive(false);
        OpenDoorText.SetActive(false);
    }

    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Key"){
            OpenDoorText.SetActive(true);
            if (Input.GetKey(KeyCode.O)){
                this.gameObject.SetActive(false);
                KeyWithDoor.SetActive(true);
                OpenDoorText.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other){
        OpenDoorText.SetActive(true);
    }

}
