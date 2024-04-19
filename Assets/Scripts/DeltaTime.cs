using UnityEngine;

public class DeltaTime : MonoBehaviour
{
	// Time.deltaTime : 이전 프레임의 완료까지 걸린 시간

	/* Time.deltaTime 사용하는 방법
	 * 
     * Translate : 벡터에 곱하기
     * translate.Translate(Vec1 * Time.deltaTime);
     * 
     * Vector 함수 : 시간 매개변수에 곱하기
     * Vector3.Lerp(Vec2, Vec3, T * Time.deltaTime);
     */
}
