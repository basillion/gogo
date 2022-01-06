using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
