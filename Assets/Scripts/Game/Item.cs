using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	[SerializeField] float rotateSpeed;
	private void Update()
	{
		// Rotate(Vector3) : �Ű����� �������� ȸ����Ű�� �Լ�
		// ���� ���ʹ� new ���� �ʰ� �ٷ� ��밡��, (0, 1, 0) y���� �������� ȸ��
		// transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		// �����ε� : �̸��� ������ �Ű������� �ٸ� �Լ��� ȣ��
		// �� �ڵ��� ������ : ������ǥ�� �ƴ� ������ǥ�� ȸ���ϱ� ������ ȸ���ϴ��� �ƴ��� �� �� ���� �������� ȸ���Ѵ�!
		transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 7)
		{
			// gameObject.SetActive(false);
			// SetActive(bool) : ������Ʈ Ȱ��ȭ �Լ�
			PlayerMove playermove = GetComponent<PlayerMove>();
			playermove.itemCount++;
			Destroy(gameObject);
		}
	}
}
