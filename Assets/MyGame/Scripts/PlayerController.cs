using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Rigidbody rigid;
	AudioSource audioSource;

	[SerializeField] GameDateManager gameDateManager;

	[SerializeField] float movePower;
	[SerializeField] float jumpPower;

	bool isGround;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
	}

	private void Update()
	{
		Jump();
	}

	private void LateUpdate()
	{
		Move();
	}

	private void Move()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		Vector3 moveVec = new Vector3(x, 0, z);
		if (isGround)
			rigid.AddForce(moveVec * movePower);

		// rigid.velocity = moveVec * moveSpeed;
		// transform.Translate(moveVec * moveSpeed * Time.deltaTime);
	}

	private void Jump()
	{
		if (Input.GetButtonDown("Jump") && isGround)
			rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.layer == 6) // Ground
			isGround = true;
	}
	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.layer == 6)
			isGround = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 8) // Item
		{
			audioSource.Play();
			gameDateManager.GetItem();
			other.gameObject.SetActive(false);
		}
	}
}
