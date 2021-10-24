using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller2D;

    // Start is called before the first frame update
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    
    float horizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }


}
