using UnityEngine;

public class SunMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public int thrust = 3;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb.AddForce(Vector2.right * thrust, ForceMode2D.Impulse);
        }    
        if (Input.GetKey("left"))
        {
            rb.AddForce(Vector2.left * thrust, ForceMode2D.Impulse);
        }    
        if (Input.GetKey("up"))
        {
            rb.AddForce(Vector2.up * thrust, ForceMode2D.Impulse);
        }    
        if (Input.GetKey("down"))
        {
            rb.AddForce(Vector2.down * thrust, ForceMode2D.Impulse);
        }    

        if (Input.GetKey("space"))
        {
            //handbreak
            rb.velocity = Vector2.zero;
        }
    }   
}
