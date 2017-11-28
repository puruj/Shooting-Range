using UnityEngine;
using System.Collections;

public class RayCastShootComplete : MonoBehaviour {

	public int gunDamage = 1;											// Set the number of hitpoints that this gun will take away from shot objects with a health script
	public float fireRate = 0.25f;										// Number in seconds which controls how often the player can fire
	public float weaponRange = 50f;										// Distance in Unity units over which the player can fire
	public float hitForce = 100f;										// Amount of force which will be added to objects with a rigidbody shot by the player
	public Transform gunEnd;											// Holds a reference to the gun end object, marking the muzzle location of the gun

	private Camera fpsCam;												// Holds a reference to the first person camera
	private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);	// WaitForSeconds object used by our ShotEffect coroutine, determines time laser line will remain visible
	private AudioSource gunAudio;										// Reference to the audio source which will play our shooting sound effect
	private LineRenderer laserLine;										// Reference to the LineRenderer component which will display our laserline
	private float nextFire;												// Float to store the time the player will be allowed to fire again, after firing
    private float counter;

	void Start () 
	{
		// Get and store a reference to our LineRenderer component
		laserLine = GetComponent<LineRenderer>();

		// Get and store a reference to our AudioSource component
		gunAudio = GetComponent<AudioSource>();

		// Get and store a reference to our Camera by searching this GameObject and its parents
		fpsCam = GetComponentInParent<Camera>();
	}
	

	void Update () 
	{
		// Check if the player has pressed the fire button and if enough time has elapsed since they last fired
		if (Input.GetButtonDown("Fire1") && Time.time > nextFire && counter < 3) 
		{
			// Update the time when our player can fire next
			nextFire = Time.time + fireRate;
            counter++;

			// Start our ShotEffect coroutine to turn our laser line on and off
            StartCoroutine (ShotEffect());

            // Create a vector at the center of our camera's viewport
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));

            // Declare a raycast hit to store information about what our raycast has hit
            RaycastHit hit;

			// Set the start position for our visual effect for our laser to the position of gunEnd
			laserLine.SetPosition (0, gunEnd.position);

			// Check if our raycast has hit anything
			if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
			{
				// Set the end position for our laser line 
				laserLine.SetPosition (1, hit.point);

				// Get a reference to a health script attached to the collider we hit

                //target 1
				ShootableBox health = hit.collider.GetComponent<ShootableBox>();
                twoPoints health2 = hit.collider.GetComponent<twoPoints>();
                threePoints health3 = hit.collider.GetComponent<threePoints>();
                fourPoints health4 = hit.collider.GetComponent<fourPoints>();
                fivePoints health5 = hit.collider.GetComponent<fivePoints>();

                //missed bullet
                Missed health6 = hit.collider.GetComponent<Missed>();

                //target 2
                Target2PointOne target2_point1 = hit.collider.GetComponent<Target2PointOne>();
                Target2PointTwo target2_point2 = hit.collider.GetComponent<Target2PointTwo>();
                Target2PointThree target2_point3 = hit.collider.GetComponent<Target2PointThree>();
                Target2Point4 target2_point4 = hit.collider.GetComponent<Target2Point4>();
                Target2Point5 target2_point5 = hit.collider.GetComponent<Target2Point5>();
                //target 3
                Target3Point1 target3_point1 = hit.collider.GetComponent<Target3Point1>();
                Target3Point2 target3_point2 = hit.collider.GetComponent<Target3Point2>();
                Target3Point3 target3_point3 = hit.collider.GetComponent<Target3Point3>();
                Target3Point4 target3_point4 = hit.collider.GetComponent<Target3Point4>();
                Target3Point5 target3_point5 = hit.collider.GetComponent<Target3Point5>();

                //target 1
                // If there was a health script attached
                if (health != null)
				{
					// Call the damage function of that script, passing in our gunDamage variable
					health.Damage (gunDamage);
				}
                // If there was a health script attached
                if (health2 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    health2.Damage(gunDamage);
                }
                // If there was a health script attached
                if (health3 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    health3.Damage(gunDamage);
                }
                // If there was a health script attached
                if (health4 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    health4.Damage(gunDamage);
                }
                // If there was a health script attached
                if (health5 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    health5.Damage(gunDamage);
                }

                //missed target
                // If there was a health script attached
                if (health6 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    health6.Damage(gunDamage);
                }


                // target 2
                // If there was a health script attached
                if (target2_point1 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target2_point1.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target2_point2 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target2_point2.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target2_point3 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target2_point3.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target2_point4 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target2_point4.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target2_point5 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target2_point5.Damage(gunDamage);
                }

                //target 3
                // If there was a health script attached
                if (target3_point1 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target3_point1.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target3_point2 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target3_point2.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target3_point3 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target3_point3.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target3_point4 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target3_point4.Damage(gunDamage);
                }

                // If there was a health script attached
                if (target3_point5 != null)
                {
                    // Call the damage function of that script, passing in our gunDamage variable
                    target3_point5.Damage(gunDamage);
                }
                // Check if the object we hit has a rigidbody attached
                if (hit.rigidbody != null)
				{
					// Add force to the rigidbody we hit, in the direction from which it was hit
					hit.rigidbody.AddForce (-hit.normal * hitForce);
				}
			}
			else
			{
				// If we did not hit anything, set the end of the line to a position directly in front of the camera at the distance of weaponRange
                laserLine.SetPosition (1, rayOrigin + (fpsCam.transform.forward * weaponRange));
			}
		}
	}


	private IEnumerator ShotEffect()
	{
		// Play the shooting sound effect
		gunAudio.Play ();

		// Turn on our line renderer
		laserLine.enabled = true;

		//Wait for .07 seconds
		yield return shotDuration;

		// Deactivate our line renderer after waiting
		laserLine.enabled = false;
	}
}