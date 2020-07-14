using UnityEngine;
using System.Collections;

public class EntityCrouch : EntityAbstraction
{
    public float scale = 0.5f;
    public bool crouching;
    public float centerOffsetY = 0f;

    private BoxCollider2D boxCollider;
    private Vector2 originalCenter;

    protected override void Awake() {
        base.Awake();

        boxCollider = GetComponent<BoxCollider2D>();
        originalCenter = boxCollider.offset;
    }

    protected virtual void OnDuck(bool value) {
        crouching = value;
        ToggleScripts(!crouching);
        var size = boxCollider.edgeRadius;
        float newOffsetY;
        float sizeReciprocal;

        if (crouching) {
            sizeReciprocal = scale;
            newOffsetY = boxCollider.offset.y - size / 2 + centerOffsetY;
        } else {
            sizeReciprocal = 1 / scale;
            newOffsetY = originalCenter.y;
        }
        size = size * sizeReciprocal;
        boxCollider.edgeRadius = size;
        boxCollider.offset = new Vector2(boxCollider.offset.x, newOffsetY);
    }

    // Update is called once per frame
    void Update() {

        var canDuck = inputState.GetButtonValue(inputButtons[0]);
        if (canDuck && collisionState.standing && !crouching) {
            OnDuck(true);
        }
        else if (crouching && !canDuck) {
            OnDuck(false);
        }

    }

}
