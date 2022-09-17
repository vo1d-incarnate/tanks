using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject GameObject_2;
	public float repeatTime;
	private float currentTime = 0;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
		if(Input.GetAxis("Jump") != 0 && currentTime <= 0)
		{
			Ray ray = new Ray(transform.position,Vector3.right);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit))
			{
				
			}
			if(hit.collider.tag == "Player")
			{
				Destroy(hit.collider.gameObject);
			}
			Debug.Log ("Boom");
			currentTime = repeatTime;
		}
    }
}
