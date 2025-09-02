using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Animator _animator;

    private bool isJumping = false;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            _animator.SetTrigger("Jump");
            isJumping = true;
        }

        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);

        if (isJumping == true && stateInfo.IsName("Jump") && stateInfo.normalizedTime >= 1.0f)
        { 
            _animator.Play("Idle");
            isJumping = false;
        }
    }
}
