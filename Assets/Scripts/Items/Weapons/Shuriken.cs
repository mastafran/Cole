using UnityEngine;
using System.Collections;


public class Shuriken : Collectable
{
    public int itemID = 1;
    public GameObject projectilePrefab;

    override protected void OnCollect(GameObject target){

        var equipBehavior = target.GetComponent<EntityEquip>();
        if (equipBehavior != null) {
            equipBehavior.CurrentItem = itemID;
        }
        var shootBehavior = target.GetComponent<EntityThrow>();
        if (shootBehavior != null) {
            shootBehavior.projectilePrefab = projectilePrefab;
        }
    }
}
