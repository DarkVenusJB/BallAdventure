using System.Collections;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float jumpDelay;

    private Rigidbody rb;
    private bool onGround=false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(jumpReload());
        }
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        rb.AddForce(moveDirection*moveSpeed);
    }

    private void Jump()
    {
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            onGround = false;
            rb.AddForce(0, jumpSpeed, 0);
        }
    }

    private IEnumerator jumpReload()
    {
        yield return new WaitForSeconds(jumpDelay);
        onGround = true;
    }
}
