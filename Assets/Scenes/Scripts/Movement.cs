using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public Animator animator;

    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    
    float horizontalMove = 0f;
    // Update is called once per frame
    void Update()
    {
        int run = Input.GetButton("Run") ? 2 : 1;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed * run;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("IsCrouching", true);
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    //There we detect if player lands on the ground
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    //There we detect if player is crouching
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
