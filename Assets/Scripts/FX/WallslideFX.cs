using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallslideFX : MonoBehaviour
{
    void OnDestroy() {
        Destroy(gameObject);
    }
}
