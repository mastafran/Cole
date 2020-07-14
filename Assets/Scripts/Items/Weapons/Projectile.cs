using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public Vector2 initialVelocity = new Vector2(100, -100);
    public int bounces = 0;
    private Rigidbody2D body;

    void Awake(){
        body = GetComponent<Rigidbody2D>();
    }

    void Start() {
        var startVelX = initialVelocity.x * transform.localScale.x;
        body.velocity = new Vector2(startVelX, initialVelocity.y);
    }  

    void OnCollisionEnter2D(Collision2D target) {
        Destroy(gameObject);
        if (bounces>0) {
            if (target.gameObject.transform.position.y < transform.position.y) {
                bounces--;
            }
            if (bounces <= 0) {
                Destroy(gameObject);
            }
        }

    }
}
