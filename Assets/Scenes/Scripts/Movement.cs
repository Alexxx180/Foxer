using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Transform _transform;
    private Rigidbody2D _rigidbody;
    public Transform GameObjectCamera;

    public CharacterController2D controller2D;

    // Start is called before the first frame update
    private Vector3 _pos => gameObject.transform.localPosition;
    private Vector3 _cam => GameObjectCamera.transform.position;
    public int speed = 10;
    private int _jump = 1;
    // Update is called once per frame
    float horizontalMove = 0f;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey("up") && _transform.localPosition.y <= 0.5f)
        {
            _rigidbody.gravityScale = -0.75f;
        }
        else
        {
            _rigidbody.gravityScale = 0.5f;
        }

        float move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 4f)
        {
            _rigidbody.AddForce(new Vector2(0, _jump), ForceMode2D.Impulse);
        }

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float scX = transform.localScale.x;

        //float move = 0.001f * _speed;
        //if (Input.GetKey("left"))
        //{
        //    transform.position = new Vector3(x - move, y, z);
        //    if (scX != -1)
        //        transform.localScale = new Vector3(scX * -1, 1f, 1f);
        //    //Debug.Log(transform.localScale);
        //}
        //else if (Input.GetKey("right"))
        //{
        //    transform.position = new Vector3(x + move, y, z);
        //    if (scX != 1)
        //        transform.localScale = new Vector3(scX * -1, 1f, 1f);
        //}
        //horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

    }

    //void FixedUpdate()
    //{
    //    controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    //}

    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Barrier")
    //    {
    //        transform.position = new Vector3(_cam.x, _cam.y, _cam.z);
    //    }
    //}


}
