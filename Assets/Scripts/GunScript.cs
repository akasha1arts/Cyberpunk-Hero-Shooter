using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damge = 10f;
    public float range = 100f;
    public float bulletForce = 30f;
    public float fireRate = 5f;
    public AudioSource gunSound;

    public Camera fpsCamera;
    public ParticleSystem gunFlash;

    private float nextTimeToFire = 0f;

    private void Awake()
    {
        gunSound = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire) //Fire1 established in Unity
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            gunSound.Play();
        }
    }

    void Shoot()
    {
        gunFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        //              Shoots from camera position,   shoots forward from camera,   checks for if in range.
        {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();

            if (enemy != null) // If object shot has no Enemy component does nothing 
            {
                enemy.TakeDamage(damge); 
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal * bulletForce);
            }

        }
       
    }


}
