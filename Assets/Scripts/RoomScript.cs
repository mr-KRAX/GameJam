using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour {
  //[SerializeField] GameObject;
  private bool roomIsActive;

  private void Start() {
    roomIsActive = false;
    //gameObject.GetComponent<SpriteRenderer>().enabled = false;
    //gameObject.GetComponent<Collider>().
  }
  private void OnTriggerExit2D(Collider2D collision) {
    Debug.Log("Exit " + collision.name);
    if (collision.name == "PlayerMain") {
      //this.gameObject.SetActive(false);
      //gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
  }
  private void OnTriggerEnter2D(Collider2D collision) {
    Debug.Log("Enter " + collision.name);
    if (collision.name == "PlayerMain") {
      //gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
  }

  private void OnTriggerStay2D(Collider2D collision) {
    //Debug.Log("Stay " + collision.name);
    //if (collision.name == "PlayerMain") {
    //  gameObject.GetComponent<Renderer>().enabled = true;
    //}
  }
}
