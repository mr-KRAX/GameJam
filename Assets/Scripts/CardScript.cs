using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour {
  [SerializeField] List<DoorScript> doors;
  [SerializeField] Text guidLine;
  bool isReady = true;


  private void OnTriggerEnter2D(Collider2D collision) {
    foreach (var d in doors) {
      d.unlock();
    }
  }
  private void OnTriggerStay2D(Collider2D collision) {
    guidLine.gameObject.SetActive(true);
    guidLine.transform.position = Camera.main.WorldToScreenPoint(this.transform.position);
  }
  private void OnTriggerExit2D(Collider2D collision) {
    this.gameObject.SetActive(false);
  }

  private void OnDrawGizmos() {
    foreach (var d in doors) {
      if (d != null) {
        // Draws a blue line from this transform to the target
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, d.gameObject.transform.position);
      }
    }
  }
}

