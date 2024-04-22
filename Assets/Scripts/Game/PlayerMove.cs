using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
	Rigidbody rigid;
	AudioSource audio;

	[SerializeField] float jumpPower;

	public int itemCount;
	public GameManager gameManager;

	bool isJump;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		audio = GetComponent<AudioSource>();
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
		if (collision.gameObject.layer == 6) // Floor
			isJump = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 8) // Item
		{
			itemCount++;
			audio.Play();
			other.gameObject.SetActive(false);
			// SetActive(bool) : 오브젝트 활성화 함수

			gameManager.GetItem(itemCount);
		}

		if (other.gameObject.tag == "Finish")
		{
			if (itemCount == gameManager.totalItemCount)
			{
				// Game Clear!
				if (gameManager.stage == 1)
					SceneManager.LoadScene("GameScene0");
				else
					SceneManager.LoadScene("GameScene" + (gameManager.stage + 1));
			}
			else
			{
				// Game Fail, Restart.
				SceneManager.LoadScene("GameScene" + gameManager.stage); // 현재 Scene 재로딩
			}
		}
	}
}
