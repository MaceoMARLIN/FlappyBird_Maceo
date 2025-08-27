using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviourScript : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
       
    }
    public void OnJump([NotNull] InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }





}
