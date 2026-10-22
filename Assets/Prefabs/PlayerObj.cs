using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerObj : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpStrength = 15;
    public float speed =1;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);    

        }

        // if(a/d is pressed) move left/right
        if(Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(Vector2.left);    

        }
        if(Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(Vector2.right);    

        }
        
    }
    
    
    //check distance method relative to nearby object
    //make method for object player interaction

}
