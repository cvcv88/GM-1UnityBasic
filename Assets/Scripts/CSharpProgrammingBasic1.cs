using System.Collections.Generic;
using UnityEngine;

public class CSharpProgrammingBasic1 : MonoBehaviour
{
	private void Start()
	{
		// 1. 변수
		// 변수 : 데이터를 메모리에 저장하는 장소
		// int float string bool
		int level = 5;                  // 정수형 데이터
		float strength = 15.5f;         // 숫자(실수)형 데이터, 뒤에 f 꼭 붙여주기
		string playerName = "마스테마";  // 문자열 데이터
		bool isFullLevel = false;       // 논리형 데이터

		// 자료형과 변수명을 작성하는 것은 선언
		// 값을 넣는 것은 초기화

		// 선언 > 초기화 > 호출(사용)

		Debug.Log("용사의 이름은?");
		Debug.Log(playerName);
		Debug.Log("용사의 레벨은?");
		Debug.Log(level);
		Debug.Log("용사의 힘은?");
		Debug.Log(strength);
		Debug.Log("용사는 만렙인가?");
		Debug.Log(isFullLevel);

		// 2. 그룹형변수 : 변수들을 묶은 하나의 장소
		// string monsters = "슬라임", "사막뱀", "악마"; -> error!
		// 배열 : 가장 기본적인 고정형 그룹형 변수
		string[] monsters = { "슬라임", "사막뱀", " 악마" };
		Debug.Log("맵에 존재하는 몬스터");
		Debug.Log(monsters[0]); // 
		Debug.Log(monsters[1]);
		Debug.Log(monsters[2]);

		int[] monsterLevel = new int[3]; // 새로운 배열을 만든다는 뜻의 new, 배열의 크기 3
		monsterLevel[0] = 1;
		monsterLevel[1] = 6;
		monsterLevel[2] = 20;
		Debug.Log("맵에 존재하는 몬스터의 레벨");
		Debug.Log(monsterLevel[0]); // 
		Debug.Log(monsterLevel[1]);
		Debug.Log(monsterLevel[2]);

		// List<type> items = new List<type>();
		// <> : Generic(제네릭)
		List<string> items = new List<string>();
		items.Add("생명물약30");
		items.Add("마나물약30");
		items.Add("공격력버프");

		items.RemoveAt(0); // 지우고 싶은 아이템 번지 수

		Debug.Log("가지고 있는 아이템");
		Debug.Log(items[0]);
		Debug.Log(items[1]);
		// Debug.Log(items[2]); // 크기를 벗어난 탐색은 오류를 발생

		// 3. 연산자 : 상수, 변수값을 연산해주는 기호
		int exp = 1500;

		exp = 1500 + 320;
		exp = exp - 10;
		level = exp / 300;
		strength = level * 3.1f;

		Debug.Log("용사의 총 경험치는?");
		Debug.Log(exp);
		Debug.Log("용사의 레벨은?");
		Debug.Log(level);
		Debug.Log("용사의 힘은?");
		Debug.Log(strength);

		int nextExp = 300 - (exp % 300); // % 몫이 아닌 나머지를 출력
		Debug.Log("다음 레벨까지 남은 경험치는?");
		Debug.Log(nextExp);

		string title = "전설의";
		Debug.Log("용사의 이름은?");
		Debug.Log(title + " " + playerName);


		int fullLevel = 99;
		isFullLevel = level == fullLevel; // level과 fullLevel이 같은지 비교
		Debug.Log("용사는 만렙입니까? " + isFullLevel);

		bool isEndTutorial = level >= 10; // level이 10보다 같거나 큰지 비교
		Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

		int health = 30;
		int mana = 25;
		bool isBadCondition = health <= 50 && mana <= 20; // && 두 값이 모두 true일 때만 true 출력
		Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

		mana = 15;
		isBadCondition = health <= 50 && mana <= 20;
		Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

		mana = 25;
		isBadCondition = health <= 50 || mana <= 20; // || 두 값 중에서 하나라도 true면 true 출력
		Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

		// ? A : B true일 때 A, false일 때 B 출력
		string condition = isBadCondition ? "나쁨" : "좋음";
		Debug.Log("용사의 상태가 나쁩니까? " + condition);

		// 4. 키워드 : 프로그래밍 언어를 구성하는 특별한 단어
		// int float = 1.f;
		// string name = List;
		// int float string bool new List
	}
}
