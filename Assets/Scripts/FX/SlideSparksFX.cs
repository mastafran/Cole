using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideSparksFX : MonoBehaviour
{
    void OnDestroy() {
        Destroy(gameObject);
    }
}
