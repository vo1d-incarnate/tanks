using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TankTurret : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameObject_1;
	private int angle = 0;
	void Start()
    {
        //transform.rotation = Quaternion.Euler(0,15,0);
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetAxis("Horizontal_1") > 0 && Input.GetAxis("Horizontal_1") != 0)
		{
			changeAngle(5);
		}
		if(Input.GetAxis("Horizontal_1") < 0 && Input.GetAxis("Horizontal_1") != 0)
		{
			changeAngle(-5);
		}
		//transform.rotation = Quaternion.Euler(0,angle,0);
		transform.Rotate(0,angle,0,Space.Self);
		angle = 0;
    }
	void FixedUpdate()
	{

	}
	public int changeAngle(int addAngle)
	{
		angle += addAngle;
		return angle;
	}
}
