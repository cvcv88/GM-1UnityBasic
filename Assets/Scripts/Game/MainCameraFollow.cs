using UnityEngine;

public class MainCameraFollow : MonoBehaviour
{
	Transform playerTransform;
	Vector3 offset;

	private void Awake()
	{
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		// FindGameObjectWithTag() : 주어진 태그로 오브젝트 검색

		offset = transform.position - playerTransform.position;
		// 카메라 위치 - 플레이어 위치
	}

	private void LateUpdate()
	{
		// transform.position = playerTransform.position;
		// 이대로 하면 공과 카메라가 붙어서 보인다!
		// 조정값 offset 필요!
		transform.position = playerTransform.position + offset;
	}
}
