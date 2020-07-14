using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoozeFX : MonoBehaviour
{
    void OnDestroy() {
        Destroy(gameObject);
    }
}
