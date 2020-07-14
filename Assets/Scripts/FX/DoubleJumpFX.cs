using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpFX : MonoBehaviour
{
    void OnDestroy() {
        Destroy(gameObject);
    }
}
