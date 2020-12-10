using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
  [SerializeField] float speed;
  [SerializeField] float acceleration;
  [SerializeField] Animator animator;
  new Rigidbody2D rigidbody;

  // Start is called before the first frame update
  void Start() {
    rigidbody = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update() {
    Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    animator.SetFloat("Speed", (Mathf.Abs(rigidbody.velocity.x) + Mathf.Abs(rigidbody.velocity.y)));
    if(!Mathf.Approximately(rigidbody.velocity.x, 0)){
      transform.localScale = new Vector3(Mathf.Sign(rigidbody.velocity.x), 1, 1);
    }
  }

  void Move(Vector2 direction) {

    Vector2 delta = direction * speed * Time.deltaTime;
    Vector2 velocity = rigidbody.velocity;
    Vector2 targetVelocity = direction * speed;
    Vector2 velocityDelta = targetVelocity - velocity;

    float maxDelta = acceleration;
    velocityDelta.x = Mathf.Clamp(velocityDelta.x, -maxDelta, maxDelta);
    velocityDelta.y = Mathf.Clamp(velocityDelta.y, -maxDelta, maxDelta);

    rigidbody.AddForce(velocityDelta * rigidbody.mass, ForceMode2D.Impulse);

  }
}