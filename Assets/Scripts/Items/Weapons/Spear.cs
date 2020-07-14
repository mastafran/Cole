using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Collectable
{
    public int itemID = 6;

    override protected void OnCollect(GameObject target)
    {

        var equipBehavior = target.GetComponent<EntityEquip>();
        if (equipBehavior != null)
        {
            equipBehavior.CurrentItem = itemID;
        }
        //var attackBehavior = target.GetComponent<FireProjectile>();
        //if (attackBehavior != null) {
        //    attackBehavior.projectilePrefab = projectilePrefab;
        //}
    }
}
