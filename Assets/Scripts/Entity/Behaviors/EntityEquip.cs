using UnityEngine;
using System.Collections;

public class EntityEquip : EntityAbstraction
{
    private int _currentItem = 0;
    private Animator animator;

    public int CurrentItem {
        get { return _currentItem; }
        set {
            _currentItem = value;
            animator.SetInteger("EquippedItem", _currentItem);       
        }
    }

    override protected void Awake() {
        base.Awake();
        animator = GetComponent<Animator>();
    }
}
