using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAttack : EntityAbstraction
{
    //public float attackDelay = .5f;
    //public Vector2 attackRange = Vector2.zero;
    //public Color debugColor = Color.cyan;
    //public float debugRadius = 3f;
    //private float timeElapsed = 0f;
    //bool isAttacking = false;

    //void Update() {
    //    if (!isAttacking) {
    //        bool canAttack = inputState.GetButtonValue(inputButtons[0]);
    //        if (canAttack && timeElapsed > attackDelay) {              
    //            timeElapsed = 0;
    //        }
    //        timeElapsed += Time.deltaTime;
    //    }
    //}

    //Vector2 CalculateAttackRange() {
    //    Vector2 pos = attackRange;
    //    pos.x *= (float)inputState.direction;
    //    pos.x += transform.position.x;
    //    pos.y += transform.position.y;
    //    return pos;
    //}

    //public void CreateProjectile(Vector2 pos) {
    //    var clone = Instantiate(projectilePrefab, pos, Quaternion.identity) as GameObject;
    //    clone.transform.localScale = transform.localScale;
    //}

    //void OnDrawGizmos() {
    //    Gizmos.color = debugColor;
    //    var pos = attackRange;
    //    if (inputState != null)
    //        pos.x *= (float)inputState.direction;
    //    pos.x += transform.position.x;
    //    pos.y += transform.position.y;
    //    Gizmos.DrawWireSphere(pos, debugRadius);
    //}

}
