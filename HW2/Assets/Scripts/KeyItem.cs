using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public GameObject KeyOnPlayer;
    public GameObject PickUpText;
    
    void Start(){
        KeyOnPlayer.SetActive(false);
        PickUpText.SetActive(false);
    }

    private void OnTriggerStay(Collider other){
        if (other.gameObject.tag == "Player"){
            PickUpText.SetActive(true);
            if (Input.GetKey(KeyCode.P)){
                this.gameObject.SetActive(false);
                KeyOnPlayer.SetActive(true);
                PickUpText.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other){
        PickUpText.SetActive(false);
    }

}
