using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Collectable
{
    public int itemID = 7;
    public GameObject projectilePrefab;

    override protected void OnCollect(GameObject target)
    {

        var equipBehavior = target.GetComponent<EntityEquip>();
        if (equipBehavior != null) {
            equipBehavior.CurrentItem = itemID;
        }
        //var shootBehavior = target.GetComponent<FireProjectile>();
        //if (shootBehavior != null) {
        //    shootBehavior.projectilePrefab = projectilePrefab;
        //}
    }
}
