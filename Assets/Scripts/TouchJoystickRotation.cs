using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;
public class TouchJoystickRotation : MonoBehaviour
{
	public Joystick joystick;
	public GameObject Object;
	Vector2 GameobjectRotation;
	private float GameobjectRotation2;
	public float daño = 10f;
	public float rango = 100f;
	public ParticleSystem efecto;
	//private LineRenderer tiro;
	public bool FacingRight = true;
	public AudioSource sonidoD;
	private WaitForSeconds shotDuration = new WaitForSeconds(.75f);
	private float nextFire;
	public float fireRate = 0.25f;
	void Update()
	{
		//Gets the input from the jostick
		GameobjectRotation = new Vector2(joystick.Horizontal, joystick.Vertical);

		
		GameobjectRotation2 = (GameobjectRotation.x + GameobjectRotation.y) * 180;
		Object.transform.rotation = Quaternion.Euler(0f, GameobjectRotation2, 0f);


		if (joystick.Horizontal.Equals(0f) && joystick.Vertical.Equals(0f) )
		{

			

		}
		else
		{
			disparo();

		}
		
		
		
		
	}

	void disparo()
	{

		efecto.Play();

		RaycastHit hit;
		if(Physics.Raycast(Object.transform.position, Object.transform.forward, out hit, rango) && Time.time > nextFire)
			{

			nextFire = Time.time + fireRate;
			
			Target target = hit.transform.GetComponent<Target>();
			StartCoroutine(shotEffect());
			if (target != null)
			{
				target.TakeDamage(daño);
				
			}
		}

	}

	private IEnumerator shotEffect()
	{
		sonidoD.Play();
		//tiro.enabled = true;
		yield return shotDuration;
		//tiro.enabled = false;
	}


}
