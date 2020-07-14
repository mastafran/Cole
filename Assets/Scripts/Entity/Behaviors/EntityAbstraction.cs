using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class EntityAbstraction : MonoBehaviour
{
    public Buttons[] inputButtons;
    public MonoBehaviour[] disableScripts;

    protected InputState inputState;
    protected Rigidbody2D body;
    protected CollisionState collisionState;

    protected virtual void Awake() {
        inputState = GetComponent<InputState>();
        body = GetComponent<Rigidbody2D>();
        collisionState = GetComponent<CollisionState>();
    }

    protected virtual void ToggleScripts(bool value) {
        foreach(var script in disableScripts) {
            script.enabled = value;
        }
    }

}
