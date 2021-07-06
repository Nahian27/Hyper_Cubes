using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public float Delay;
    public GameObject Cube;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            Vector3 ScreenToWorld = Camera.main.ScreenToWorldPoint(transform.position);
            Instantiate(Cube, new Vector3(Random.Range(-ScreenToWorld.x, ScreenToWorld.x), 10, 0), Quaternion.identity);
            yield return new WaitForSeconds(Delay);
        }
    }
}
