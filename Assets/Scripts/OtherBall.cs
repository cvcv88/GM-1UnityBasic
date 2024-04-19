using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
	MeshRenderer mesh; // ������Ʈ�� ���� ������ MeshRenderer�� ���ؼ�
	Material mat;

	void Start()
	{
		mesh = GetComponent<MeshRenderer>();
		mat = mesh.material;
	}

	// Collision : �浹 ���� Ŭ����
	// CollisionEnter: ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "MyBall")
		{
			mat.color = new Color(1, 1, 1); // white(1, 1, 1) / black (0, 0, 0)
			// Color : �⺻ ���� Ŭ����, Color32 : 255 ���� Ŭ����
		}
	}

	// CollisionStay : ������ �浹�� �Ͼ�� ���� �� ȣ��Ǵ� �Լ�
	private void OnCollisionStay(Collision collision)
	{

	}

	// CollisionExit : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.name == "MyBall")
		{
			mat.color = new Color(0, 0, 0); // white(1, 1, 1) / black (0, 0, 0)
											// Color : �⺻ ���� Ŭ����, Color32 : 255 ���� Ŭ����
		}
	}
}
