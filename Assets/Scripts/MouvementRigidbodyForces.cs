using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRigidbodyForces : MonoBehaviour
{
    public Vector3 forceInitiale = Vector3.zero;
    private Rigidbody _rb;

    void Start()
    {
        // Prends une r�ference au Rigidbody attach� a cet objet.
        _rb = GetComponent<Rigidbody>();

        _rb.AddForce(forceInitiale, ForceMode.VelocityChange);
    }
}
