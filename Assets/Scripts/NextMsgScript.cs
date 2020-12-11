using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMsgScript : MonoBehaviour {
  [SerializeField] GameManagerScript gms;
  bool flag = true;

  private void OnTriggerEnter2D(Collider2D collision) {
    if (!flag)
      return;
    flag = false;
    gms.NextMessage();
  }

}
