using UnityEngine;
using System.Collections;

public class EntityThrow : EntityAbstraction
{
    public float throwDelay = 0.5f;
    public GameObject projectilePrefab;
    public Vector2 throwPosition = Vector2.zero;
    public Color debugColor = Color.yellow;
    public float debugRadius = 3f;
    private float timeElapsed = 0f;

    // Update is called once per frame
    void Update() {
        if (projectilePrefab != null) {
            var canThrow = inputState.GetButtonValue(inputButtons[0]);
            if (canThrow && timeElapsed > throwDelay) {
                CreateProjectile(CalculateFirePosition());
                timeElapsed = 0;
            }
            timeElapsed += Time.deltaTime;
        }
    }

    Vector2 CalculateFirePosition() {
        var pos = throwPosition;
        pos.x *= (float)inputState.direction;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        return pos;
    }

    public void CreateProjectile(Vector2 pos) {
        var clone = Instantiate(projectilePrefab, pos, Quaternion.identity) as GameObject;
        clone.transform.localScale = transform.localScale;
    }

    void OnDrawGizmos() {
        Gizmos.color = debugColor;
        var pos = throwPosition;
        if (inputState != null)
            pos.x *= (float)inputState.direction;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        Gizmos.DrawWireSphere(pos, debugRadius);
    }
}
