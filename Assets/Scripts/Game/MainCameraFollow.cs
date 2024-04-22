using UnityEngine;

public class MainCameraFollow : MonoBehaviour
{
	Transform playerTransform;
	Vector3 offset;

	private void Awake()
	{
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		// FindGameObjectWithTag() : �־��� �±׷� ������Ʈ �˻�

		offset = transform.position - playerTransform.position;
		// ī�޶� ��ġ - �÷��̾� ��ġ
	}

	private void LateUpdate()
	{
		// transform.position = playerTransform.position;
		// �̴�� �ϸ� ���� ī�޶� �پ ���δ�!
		// ������ offset �ʿ�!
		transform.position = playerTransform.position + offset;
	}
}
