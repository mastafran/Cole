using UnityEngine;
using System.Collections;

public class EntityWalk : EntityAbstraction
{

    public float speed = 75f;
    public float acclerator = 2f;
    public bool running;

    void Update() {

        running = false;

        bool right = inputState.GetButtonValue(inputButtons[0]);
        bool left = inputState.GetButtonValue(inputButtons[1]);
        bool run = inputState.GetButtonValue(inputButtons[2]);

        if (right || left) {
            var tempSpeed = speed;
            if (run && acclerator > 0) {
                tempSpeed *= acclerator;
                running = true;
            }
            var velocityX = tempSpeed * (float)inputState.direction;
            body.velocity = new Vector2(velocityX, body.velocity.y);
        }
    }
}
