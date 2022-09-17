using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTank : MonoBehaviour, IPunObservable
{
	//photon
	private PhotonView photonView;
	private SpriteRenderer spriteRenderer;
	private bool isRed;
	//for center of mass
	//public Vector3 com = new Vector3(0,0,0);
	//other
	public float maxSpeed = 20f;
	public float xspeed = 5;
	public Rigidbody rb;
    
	//photon
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.IsWriting)
		{
			stream.SendNext(isRed);
		}
		else
		{
			isRed = (bool) stream.ReceiveNext();
		}
	}
	// Start is called before the first frame update
    void Start()
	{
		rb = GetComponent<Rigidbody>();
		//rb.centerOfMass = com;
		
		//photon
		photonView = GetComponent<PhotonView>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		
    }

    // Update is called once per frame
    void Update()
    {
        
		
    }
	void FixedUpdate()
	{
		//photon
		if (photonView.IsMine)
		{
			
			//move
			rb.AddForce(transform.right*Input.GetAxis("Vertical")*xspeed, ForceMode.Force);
			//rb.velocity = new Vector3(Input.GetAxis("Vertical")*xspeed,0,0);
			rb.angularVelocity = new Vector3(0,Input.GetAxis("Horizontal"),0);
		
			if(GetComponent<Rigidbody>().velocity.magnitude > maxSpeed)
			{
				GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxSpeed;
			}
			if (Input.GetKey(KeyCode.Tab))
			{
				isRed = true;
			}
			else
			{
				isRed = false;
			}
		}
		if (isRed)
		{
			spriteRenderer.color = Color.red;
		}
		else
		{
			spriteRenderer.color = Color.white;
		}
		
	}
}