using UnityEngine;
using System.Collections;

public class EntityGrab : EntityAbstraction
{
    public bool onWallDetected;
    protected float defaultGravityScale;
    protected float defaultDrag;

    void Start() {
        defaultGravityScale = body.gravityScale;
        Debug.Log("BODY GEAVITY SCALE: " +body.gravityScale);
        defaultDrag = body.drag;
    }

    protected virtual void Update() {
        if (collisionState.onWall) {
            if (!onWallDetected) {
                OnGrab();
                ToggleScripts(false);
                onWallDetected = true;
            }
        } else {
            if (onWallDetected) {
                OffWall();
                ToggleScripts(true);
                onWallDetected = false;
            }
        }
    }

    protected virtual void OnGrab() {
        if (!collisionState.standing && body.velocity.y > 0) {
            body.gravityScale = 0;
            body.drag = 2000;
        }
    }

    protected virtual void OffWall() {
        if (body.gravityScale != defaultGravityScale) {
            body.gravityScale = defaultGravityScale;
            body.drag = defaultDrag;
        }
    }
}
