using UnityEngine;

public class PlayerColliosions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "obstacle")
        {
            Destroy(gameObject);
            //game over screen but thats a tmr issue
            //gamemanger set game over
        }
    }
}
