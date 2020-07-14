using UnityEngine;
using System.Collections;

public class EntityWallslide : EntityGrab
{
    public float slideVelocity = -5f;
    public float slideMultiplier = 5f;
    public GameObject wallslideFXPrefab;
    public float dustSpawnDelay = 1.0f;
    private float timeElapsed = 0f;

    // Update is called once per frame
    override protected void Update() {
        base.Update();

        if (onWallDetected && !collisionState.standing) {
            var velY = slideVelocity;

            if (inputState.GetButtonValue(inputButtons[0]))
                velY *= slideMultiplier;

            body.velocity = new Vector2(body.velocity.x, velY);

            if (timeElapsed > dustSpawnDelay) {

                var dust = Instantiate(wallslideFXPrefab);
                var pos = transform.position;
                //pos.y += 2;
                dust.transform.position = pos;
                dust.transform.localScale = transform.localScale;
                timeElapsed = 0;
            }
            timeElapsed += Time.deltaTime;
        }
    }

    override protected void OnGrab() {
        body.velocity = Vector2.zero;
    }

    override protected void OffWall() {
        timeElapsed = 0;
    }
}
