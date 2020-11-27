using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float acceleration;
    new Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    void Move(Vector2 direction) {
        Vector2 velocity = rigidbody.velocity;
        Vector2 targetVelocity = direction * speed;
        Vector2 velocityDelta = targetVelocity - velocity;

        float maxDelta = acceleration;
        velocityDelta.x = Mathf.Clamp(velocityDelta.x, -maxDelta, maxDelta);
        velocityDelta.y = Mathf.Clamp(velocityDelta.y, -maxDelta, maxDelta);
        
        rigidbody.AddForce(velocityDelta * rigidbody.mass, ForceMode2D.Impulse);
    }
}
