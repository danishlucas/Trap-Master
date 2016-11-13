using UnityEngine;
using System.Collections;

public class SpikeActivationScript : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb;
    private bool active;
    private float timer;
    private bool ready;
    public float cooldown;
	// Use this for initialization
	void Start () {
        timer = cooldown;
        rb = GetComponent<Rigidbody2D>();
        active = false;
        ready = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer >= cooldown)
        {
            ready = true;
        }
        if (Input.GetKeyDown(KeyCode.Keypad1) && ready) //KeyCode.Keypad1 = 1, etc
        {
            active = true;
        }
        if (!ready)
        {
            timer += Time.deltaTime;
        }
        if (active && ready) {
            active = false;
            Vector2 v2 = new Vector2(0.0f, speed);
            rb.AddForce(v2);
            timer = 0;
            ready = false;
        }
	}
}
