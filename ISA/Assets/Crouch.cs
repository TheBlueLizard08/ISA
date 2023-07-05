using UnityEngine;

public class Crouch : MonoBehaviour
{
    Animator animator;

    // Update is called once per frame
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
        void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.Play("crouchAnim");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.Play("CrouchEnd");
        }
    }

    public void PlayerCrouch()
    {
        
    }

    public void PlayerCrouchEnd()
    {
        
    }
}
