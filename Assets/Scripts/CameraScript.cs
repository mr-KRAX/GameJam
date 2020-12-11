using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
  public Transform playerTransform;
  bool followingPlayer = true;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown("f")) {
      followingPlayer = !followingPlayer;
      print(followingPlayer);
    }
  }

  void FixedUpdate() {
    if (followingPlayer) {
      this.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, this.transform.position.z);
    }
  }
}