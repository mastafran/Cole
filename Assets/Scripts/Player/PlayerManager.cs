using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    private InputState inputState;
    private EntityWalk walkBehavior;
    private EntityCrouch crouchBehavior;
    private Animator animator;
    private CollisionState collisionState;
    
    void Awake() {
        inputState = GetComponent<InputState>();
        walkBehavior = GetComponent<EntityWalk>();
        crouchBehavior = GetComponent<EntityCrouch>();
        animator = GetComponent<Animator>();
        collisionState = GetComponent<CollisionState>();
    }

    void Update() {
        if (collisionState.standing) {
            ChangeAnimationState(0);//idle
        }
        if (inputState.absVelX > 0) {
            ChangeAnimationState(1);//walk
        }
        if (inputState.absVelY > 0) {
            ChangeAnimationState(2);//jump
        }

        animator.speed = walkBehavior.running ? walkBehavior.acclerator : 1;

        if (crouchBehavior.crouching) {
            ChangeAnimationState(3);//crouch
        }

        if (!collisionState.standing && collisionState.onWall) {
            Debug.Log("ON WALL");
            ChangeAnimationState(4);//grab
        }
    }

    void ChangeAnimationState(int value) {
        animator.SetInteger("AnimationState", value);
    }

}
