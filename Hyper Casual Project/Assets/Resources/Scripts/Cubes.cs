using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public float DestroyAfter, RotationSpeed;


    void Start()
    {
        StartCoroutine(DeSpawn());
    }

    void FixedUpdate()
    {
        RotationSpeed++;
        transform.rotation = Quaternion.Euler(RotationSpeed, RotationSpeed, RotationSpeed);
    }
    IEnumerator DeSpawn()
    {
        yield return new WaitForSeconds(DestroyAfter);
        Destroy(gameObject);
    }
}
