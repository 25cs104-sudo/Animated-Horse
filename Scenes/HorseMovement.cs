using UnityEngine;

public class HorseMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float turnSpeed = 100f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);

        transform.Translate(Vector3.forward * forward * moveSpeed * Time.deltaTime);

        bool isWalking = Mathf.Abs(forward) > 0.1f;

        animator.SetBool("isWalking", isWalking);
    }
}
