using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject endpanel;
    private string Enemy = "Enemy";

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Enemy) 
        {
            endpanel . SetActive(true);
            gameObject .SetActive(false);
        }
    }
    
}
