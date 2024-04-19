using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
	MeshRenderer mesh; // 오브젝트의 재질 접근은 MeshRenderer를 통해서
	Material mat;

	void Start()
	{
		mesh = GetComponent<MeshRenderer>();
		mat = mesh.material;
	}

	// Collision : 충돌 정보 클래스
	// CollisionEnter: 물리적 충돌이 시작할 때 호출되는 함수
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "MyBall")
		{
			mat.color = new Color(1, 1, 1); // white(1, 1, 1) / black (0, 0, 0)
			// Color : 기본 색상 클래스, Color32 : 255 색상 클래스
		}
	}

	// CollisionStay : 물리적 충돌이 일어나는 중일 때 호출되는 함수
	private void OnCollisionStay(Collision collision)
	{

	}

	// CollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수
	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.name == "MyBall")
		{
			mat.color = new Color(0, 0, 0); // white(1, 1, 1) / black (0, 0, 0)
											// Color : 기본 색상 클래스, Color32 : 255 색상 클래스
		}
	}
}
