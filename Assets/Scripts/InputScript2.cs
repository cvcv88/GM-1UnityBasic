using UnityEngine;

public class InputScript2 : MonoBehaviour
{
	// Transform : 오브젝트 형태에 대한 기본 컴포넌트
	// position, rotation, scale
	// 오브젝트는 변수 transform을 항상 가지고 있음. 초기화 할 필요 없음.

	private void Start()
	{
		// Vector 벡터
		int number = 4; // 스칼라 값 : 순수한 값
		Vector3 vec = new Vector3(2, 2, 2); // 방향과 그에 대한 크기 값

		// Transflate : 벡터 값을 현재 위치에 더하는 함수
		// transform.Translate(vec);
	}

	private void Update()
	{
		// Vector3 vec = new Vector3(0, 0.1f, 0);
		Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.Translate(vec);
	}
}
