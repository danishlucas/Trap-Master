using UnityEngine;
using System.Collections;

public class SpikeActivationScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float nextFire = 0.0f;
    public float ogXPos;
    public float ogYPos;
    public float cooldown;
    public float maxHeight;
    private bool goingDown;
    private float timer;
    public float delayAtTop;
    // Use this for initialization
    void Start()
    {
        timer = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("SpikeActivation") && Time.time > nextFire)
        {
            Debug.Log("its game time");
            nextFire = Time.time + cooldown;
            rb.velocity = new Vector2(0.0f, speed);
        }
        if (rb.position.y >= ogYPos + maxHeight && !goingDown)
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
            timer += Time.deltaTime;
            if (timer >= delayAtTop)
            {
                goingDown = true;
                timer = 0;
            }
        }
        if (goingDown)
        {
            rb.velocity = new Vector2(0.0f, -speed);
            if (rb.position.y <= ogYPos)
            {
                rb.MovePosition(new Vector2(ogXPos, ogYPos));
                goingDown = false;
            }
        }
    }

}
