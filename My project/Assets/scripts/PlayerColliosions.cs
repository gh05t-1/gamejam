using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerColliosions : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.onPlay.AddListener(ActivatePLayer);

        
    }
    private void ActivatePLayer()
    {
        gameObject.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.transform.tag == "obstacle")
        {
            gameObject.SetActive(false);
            GameManager.Instance.GameOver();
        }
    }
}
