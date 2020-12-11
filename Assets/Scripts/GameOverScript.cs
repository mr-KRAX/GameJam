using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
  bool flag = true;
  [SerializeField] GameManagerScript gms;
  private void OnTriggerEnter2D(Collider2D collision) {
    if (flag) {
      Debug.Log("GameOver");
      gms.GameOver(true);
      flag = false;
    }
  }
}
