using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Collectable
{
    public int itemID = 5;

    override protected void OnCollect(GameObject target)
    {

        var equipBehavior = target.GetComponent<EntityEquip>();
        if (equipBehavior != null) {
            equipBehavior.CurrentItem = itemID;
        }
        //var attackBehavior = target.GetComponent<FireProjectile>();
        //if (attackBehavior != null) {
        //    attackBehavior.projectilePrefab = projectilePrefab;
        //}
    }
}
