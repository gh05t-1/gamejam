using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D colliders;
    public Rigidbody2D rb;

    private float width;
    [SerializeField] private float scrollSpeed = -2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colliders = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = colliders.size.x;
        colliders.enabled = false;
        rb.linearVelocity = new Vector2(scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosistion = new Vector2(width * 2f, 0);
            transform.position = (Vector2) transform.position + resetPosistion;
        }
    }
}
