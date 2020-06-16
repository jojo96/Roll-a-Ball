using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plyerController : MonoBehaviour
{
	private Rigidbody rb;
	public float speed;
	private int count;
	public Text countText;
	public Text WinText;

	void Start(){
		speed = 10;
		count = 0;
		rb = GetComponent<Rigidbody>();
		WinText.text = "";
		setCount();

	}
	
    void Update()
	{}


	void OnTriggerEnter(Collider Other) {
		if (Other.gameObject.CompareTag("PickUp"))
			Other.gameObject.SetActive(false);
		count += 1;
		setCount();

	}


	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		rb.AddForce(movement*speed);
	    
	}

	void setCount() {
		countText.text = "Count: " + count.ToString();
		if (count >= 7)
			WinText.text = " YOU WIN ";
	}
	
	
	
	
	
}
