using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : Collectable
{
    public int itemID = 2;

    override protected void OnCollect(GameObject target) {

        var equipBehavior = target.GetComponent<EntityEquip>();
        if (equipBehavior != null) {
            equipBehavior.CurrentItem = itemID;
        }
        var attackBehavior = target.GetComponent<EntityAttack>();
        if (attackBehavior != null) {
            Debug.Log("ATACKING");
        }
    }
}
