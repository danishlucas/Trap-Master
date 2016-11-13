using UnityEngine;
using System.Collections;

public class ProjectileActivationScript : MonoBehaviour {
    private Rigidbody2D rb;
    private bool active;
    private float nextFire = 0.0f;
    public float cooldown = 2.5f;

    public GameObject shot;
    public GameObject shotSpawn;

	// Use this for initialization
	void Start () {
        
        rb = GetComponent<Rigidbody2D>();
        active = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButton("fireProjectile") && Time.time > nextFire)
        {
            Debug.Log("its game time");
            nextFire = Time.time + cooldown;
            Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
        }

        
	}
}
