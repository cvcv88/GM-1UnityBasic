using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
	[SerializeField] float rotateSpeed;
	private void Update()
	{
		// Rotate(Vector3) : 매개변수 기준으로 회전시키는 함수
		// 단위 벡터는 new 하지 않고 바로 사용가능, (0, 1, 0) y축을 기준으로 회전
		// transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		// 오버로드 : 이름은 같지만 매개변수가 다른 함수를 호출
		// 이 코드의 문제점 : 월드좌표가 아닌 로컬좌표로 회전하기 때문에 회전하는지 아닌지 알 수 없는 방향으로 회전한다!
		transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 7)
		{
			// gameObject.SetActive(false);
			// SetActive(bool) : 오브젝트 활성화 함수
			PlayerMove playermove = GetComponent<PlayerMove>();
			playermove.itemCount++;
			Destroy(gameObject);
		}
	}
}
