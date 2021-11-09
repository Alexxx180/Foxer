using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public Animator animator;

    // Start is called before the first frame update
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
            //Debug.Log(animator.GetBool("IsJumping"));
        }

        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("IsCrouching", true);
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            //animator.SetBool("IsCroaching", false);
            crouch = false;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        //Debug.Log(animator.GetBool("IsJumping"));
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
        //Debug.Log(animator.GetBool("IsJumping"));
    }

    void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
