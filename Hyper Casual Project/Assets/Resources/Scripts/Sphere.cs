using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float Speed;
    private bool moveLeft, moveRight;
    public GameObject HUD, GameOverMenu, ParticleEffect;

    void Start()
    {
        moveLeft = moveRight = false;
    }
    public void LeftPointerDown()
    {
        moveLeft = true;
    }
    public void LeftPointerUp()
    {
        moveLeft = false;
    }
    public void RightPointerDown()
    {
        moveRight = true;
    }
    public void RightPointerUp()
    {
        moveRight = false;
    }

    void FixedUpdate()
    {
        if (moveLeft == true || Input.GetKeyDown(KeyCode.LeftArrow)) transform.position += new Vector3(-Speed, 0, 0);
        if (moveRight == true || Input.GetKeyDown(KeyCode.RightArrow)) transform.position += new Vector3(Speed, 0, 0);
    }

    void OnCollisionEnter()
    {
        Destroy(gameObject);
        HUD.SetActive(false);
        GameOverMenu.SetActive(true);
        Instantiate(ParticleEffect, transform.position, Quaternion.identity);
    }
}
