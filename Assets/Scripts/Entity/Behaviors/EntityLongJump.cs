using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allows pressing jump button longer to extend jump height
public class EntityLongJump : EntityJump
{
    public float longJumpDelay = 0.15f;
    public float longJumpMultiplier = 1.2f;
    public bool canLongJump;
    public bool isLongJumping;

    protected override void Update() {

        bool canJump = inputState.GetButtonValue(inputButtons[0]);
        float holdTime = inputState.GetButtonHoldTime(inputButtons[0]);

        if (!canJump) {
            canLongJump = false;
        }

        if (collisionState.standing && isLongJumping) {
            isLongJumping = false;
        }

        base.Update(); 

        if (canLongJump && !collisionState.standing && holdTime > longJumpDelay)
        {

            var vel = body.velocity;
            body.velocity = new Vector2(vel.x, jumpSpeed * longJumpMultiplier);
            canLongJump = false;
            isLongJumping = true;
        }
    }

    protected override void OnJump() {
        base.OnJump();
        canLongJump = true;
    }
}
