using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
	/* Unity LifeCycle */

	// 초기화 단계(영역)
	// - Awake() 게임 오브젝트 생성할 때, 최초 실행
	// - Start() 업데이터 시작 직전, 최초 실행
	private void Awake()
	{
		Debug.Log("플레이어 데이터가 준비되었습니다.");
	}

	private void Start()
	{
		Debug.Log("사냥 장비를 챙겼습니다.");
	}

	// 물리 + 게임로직 = 프레임
	// 물리 연산 단계(영역)
	// - FixedUpdate() 물리 연산 업데이트, 1초에 50번 실행, 고정된 실행 주기로 ^CPU를 많이 사용^
	private void FixedUpdate()
	{
		Debug.Log("이동~");
	}

	// 게임 로직 단계(영역)
	// - Update() 게임 로직 업데이트, 물리 연산을 제외한 나머지, 주기적으로 변하는 로직을 넣을 때 사용, 환경에 따라서 ^실행 주기가 떨어질 수 있다^
	// - LateUpdate() 모든 업데이트 끝난 후, 캐릭터를 따라가는 카메라, 로직의 후처리 등 을 담는 곳
	private void Update()
	{
		Debug.Log("몬스터 사냥!!");
	}

	private void LateUpdate()
	{
		Debug.Log("경험치 획득~!");
	}

	// 해체 단계(영역)
	// - OnDestroy() 게임 오브젝트가 삭제될 때
	private void OnDestroy()
	{
		Debug.Log("플레이어 데이터를 해제하였습니다.");
	}

	// 활성화 단계(영역) : 초기화 <- 활성화 -> 물리
	// - OnEnable() 게임 오브젝트가 활성화 되었을 때, 최초 1회 실행이 아닌 켜고 끌때마다 실행
	private void OnEnable()
	{
		Debug.Log("플레이어가 로그인했습니다.");
	}

	// 비활성화 단계(영역) : 게임 로직 <- 비활성화 -> 해체
	// - OnDisable() 게임 오브젝트가 비활성화 되었을 때
	private void OnDisable()
	{
		Debug.Log("플레이어가 로그아웃했습니다.");
	}
}
