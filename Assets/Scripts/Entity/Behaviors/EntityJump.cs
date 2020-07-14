using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityJump : EntityAbstraction
{
    public float jumpSpeed = 200.0f;
    public float jumpDelay = 0.1f;
    public int jumpCount = 2;
    public GameObject dJumpFXFab;
    protected float lastJumpTime = 0.0f;
    protected float jumpsRemaining = 0.0f;

    protected virtual void Update() {
        bool canJump = inputState.GetButtonValue(inputButtons[0]);
        float holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

        if (collisionState.standing){
            if (canJump && holdTime < 0.1f) {
                jumpsRemaining = jumpCount - 1;
                OnJump();
            } 
        } else {
            if (canJump && holdTime < 0.1f && Time.time - lastJumpTime > jumpDelay) {

                if (jumpsRemaining > 0) {
                    OnJump();
                    jumpsRemaining--;
                    GameObject clone = Instantiate(dJumpFXFab);
                    clone.transform.position = transform.position;
                }
            }
        }
}

    protected virtual void OnJump() {
        Vector2 vel = body.velocity;
        lastJumpTime = Time.time;
        body.velocity = new Vector2(vel.x, jumpSpeed);
    }
}
