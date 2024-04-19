using UnityEngine;

public class MyBall : MonoBehaviour
{
	// 선언 초기화 호출
	Rigidbody rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		// 해당 스크립트가 붙은 게임 오브젝트의 Rigidbody 컴포넌트를 가져온다.
		// GetComponent<T> : 자신의 T타입 컴포넌트를 가져옴.

		// velocity : 현재 이동 속도

		// 한번만 힘을 가해주고 끝남
		// rigid.velocity = Vector3.right;
		// rigid.velocity = new Vector3(2, 4, 3);
	}

	private void FixedUpdate()
	{
        // 계속해서 Update 되면서 속도 유지
        // rigid.velocity = Vector3.right; // 속력 바꾸기
        // rigid.velocity = new Vector3(2, 4, 3);

        // if (Input.GetButtonDown("Jump"))
        // {
			// ForceMode : 힘을 주는 방식(가속, 무게 반영)
			// rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
		// }

		// Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		// rigid.AddForce(vec, ForceMode.Impulse);
		// Rigidbody를 이용한 이동은 보다 자연스럽다.

		// 회전력, AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김
		rigid.AddTorque(Vector3.back);
		rigid.AddTorque(Vector3.up);
	}
}
