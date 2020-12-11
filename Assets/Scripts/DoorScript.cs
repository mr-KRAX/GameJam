using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum DoorType { UP, DOWN, LEFT, RIGHT };

public class DoorScript : MonoBehaviour {
  [SerializeField] DoorScript nextDoor;
  [SerializeField] bool isActivated = true;
  [SerializeField] bool isLocked = true;
  [SerializeField] DoorType type;
  [SerializeField] Text guidLine;
  bool isReady = true;
  bool isWaitihg = false;

  private void Start() {
  }

  private void Update() {
    if (!isActivated)
      return;
    if (isWaitihg) {
      DisplayGuideLine("The door is opened");
    }
  }

  private void OnTriggerEnter2D(Collider2D collision) {
    
  }

  private void OnTriggerStay2D(Collider2D collision) {
    if (!isReady || !isActivated)
      return;
    if (isWaitihg)
      isWaitihg = false;
    if (isLocked) {
      DisplayGuideLine("Locked!\n The card is needed!");
      return;
    }
    DisplayGuideLine("Press \"E\" to enter the door");
    if (Input.GetKey("e")) {
      collision.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
      collision.transform.position = nextDoor.teleportTo() + new Vector2(0, 2);

    }
  }

  private void OnTriggerExit2D(Collider2D collision) {
    HideGuideLine();
    if (!isActivated)
      return;
    isReady = true;
  }

  private void DisplayGuideLine(string msg = "") {
    guidLine.text = msg;
    guidLine.gameObject.SetActive(true);
    guidLine.transform.position = Camera.main.WorldToScreenPoint(this.transform.position);
  }

  private void HideGuideLine() {
    guidLine.gameObject.SetActive(false);
  }


  public Vector2 teleportTo() {
    transform.parent.parent.gameObject.SetActive(true);
    nextDoor.transform.parent.parent.gameObject.SetActive(false);
    if (isActivated)
      isReady = false;
    return getTPPosition();
  }

  public Vector2 getTPPosition() {
    BoxCollider2D col = this.GetComponent<BoxCollider2D>();

    //col.transform.
    Vector2 pos = new Vector2(transform.position.x, transform.position.y);
    pos += col.offset / 2;
    return pos;
  }

  public void unlock() {
    if (isLocked) {
      isLocked = false;
      isWaitihg = true;
    }
  }
  void OnDrawGizmos() {
    if (nextDoor != null) {
      // Draws a blue line from this transform to the target
      Gizmos.color = Color.blue;
      Gizmos.DrawLine(transform.position, nextDoor.gameObject.transform.position);
    }
  }


}
