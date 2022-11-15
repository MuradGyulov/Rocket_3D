using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionParticle : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(gameObject, 2f);
    }
}
