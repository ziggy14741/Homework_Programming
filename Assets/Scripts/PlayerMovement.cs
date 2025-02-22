using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    private float _xSpeed;
    private float _ySpeed;
    public float speed = 20;
    private string _ImputX = "Horizontal";
    private string _ImputY = "Vertical";

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
         
    }

    private void Update()
    {
        _xSpeed = Input.GetAxis(_ImputX);
        _ySpeed = Input.GetAxis(_ImputY);

        rigidbody2D.velocity = new Vector2(_xSpeed, _ySpeed)* 5;
    }
}
