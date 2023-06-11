using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float Speed;
    private bool moveLeft, moveRight, _moveLeft, _moveRight;
    public GameObject HUD, GameOverMenu, ParticleEffect;
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        moveLeft = moveRight = false;
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<MeshRenderer>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.extents.y; //extents = size of height / 2
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

    void Update()
    {
        _moveLeft = moveLeft || Input.GetKey(KeyCode.LeftArrow);
        _moveRight = moveRight || Input.GetKey(KeyCode.RightArrow);
    }

    void FixedUpdate()
    {
        if (_moveLeft)
            transform.position += new Vector3(-Speed, 0, 0);
        if (_moveRight)
            transform.position += new Vector3(Speed, 0, 0);

    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
        transform.position = viewPos;
    }
    void OnCollisionEnter()
    {
        Destroy(gameObject);
        HUD.SetActive(false);
        GameOverMenu.SetActive(true);
        Instantiate(ParticleEffect, transform.position, Quaternion.identity);
    }
}
