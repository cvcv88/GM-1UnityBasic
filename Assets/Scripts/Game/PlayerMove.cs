using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	Rigidbody rigid;

	[SerializeField] float jumpPower;

	public int itemCount;

	bool isJump;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		isJump = false;
	}
	private void Update()
	{
		if (Input.GetButtonDown("Jump") && !isJump)
		{
			isJump = true;
			rigid.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse);
		}
	}
	private void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		Vector3 vec = new Vector3(h, 0, v);
		rigid.AddForce(vec, ForceMode.Impulse);
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer == 6)
			isJump = false;
	}
}
