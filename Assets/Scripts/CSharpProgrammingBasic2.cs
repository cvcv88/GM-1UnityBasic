using System.Collections.Generic;
using UnityEngine;

public class CSharpProgrammingBasic2 : MonoBehaviour
{
	int health1 = 30; // 전역변수(멤버변수) : 함수 바깥에 선언된 변수
	int level = 5;
	// 지역변수 : 함수 안에서 선언된 변수
	private void Start()
	{
		int health = 30;
		int health2 = 30;
		int mana = 15;
		bool isBadCondition = health <= 50 && mana <= 20;
		string condition = isBadCondition ? "나쁨" : "좋음";

		List<string> items = new List<string>();
		items.Add("생명물약30");
		items.Add("마나물약30");
		items.Add("공격력버프");

		string[] monsters = { "슬라임", "사막뱀", " 악마" };
		int[] monsterLevel = new int[3];

		// 5. 조건문
		// if : 조건이 true일 때, 로직 실행
		if (condition == "나쁨")
		{
			Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
		}
		else
		{
			Debug.Log("플레이어 상태가 좋습니다.");
		}

		if (isBadCondition && items[0] == "생명물약30")
		{
			items.RemoveAt(0);
			health += 30;
			Debug.Log("생명포션30을 사용하였습니다.");
		}
		else if (isBadCondition && items[0] == "마나물약30")
		{
			items.RemoveAt(0);
			mana += 30;
			Debug.Log("마나포션30을 사용하였습니다.");
		}

		// switch, case : 변수의 값에 따라 로직 실행
		switch (monsters[0])
		{
			case "슬라임":
			case "사막뱀":
				Debug.Log("소형 몬스터가 출현!");
				break;
			case "악마":
				Debug.Log("중형 몬스터가 출현!");
				break;
			case "골렘":
				Debug.Log("대형 몬스터가 출현!");
				break;
			default:
				Debug.Log("??? 몬스터가 출연!");
				break;
		}


		// 6. 반복문 : 조건에 만족하면 로직을 반복하는 제어문
		// while : 조건이 true일때, 로직 반복 재생
		while (health > 0)
		{
			health--;
			if (health > 0)
				Debug.Log("독 데미지를 입었습니다. " + health);
			else
				Debug.Log("사망하였습니다.");

			if (health == 10)
			{
				Debug.Log("해독제를 사용합니다.");
				break;
			}
		}

		// for : 변수를 연산하면서 로직 반복 실행
		// 연산에 사용할 변수 ; 조건 ; 연산
		// 그룹형 변수 길이 : .Length(배열) .Count(리스트)
		for (int count = 0; count < 10; count++)
		{
			health++;
			Debug.Log("붕대로 치료중... " + health);
		}

		for (int index = 0; index < monsters.Length; index++)
		{
			Debug.Log("이 지역에 있는 몬스터(for) : " + monsters[index]);
		}

		foreach (string monster in monsters)
		{
			Debug.Log("이 지역에 있는 몬스터(foreach) : " + monster);
		}

		health2 = Heal1(health2);
		Heal2();

		for (int index = 0; index < monsters.Length; index++)
		{
			Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
		}

		// 8. 클래스
		Actor player = new Actor(); // 클래스를 하나의 변수로 생성 -> 인스턴스화 (인스턴스 : 정의된 클래스를 변수 초기화로 실체화)
		player.id = 0;
		player.name = "김전사";
		player.title = "짱센";
		player.strength = 2.5f;
		player.weapon = "몽둥이";
		Debug.Log(player.Talk());
		Debug.Log(player.HasWeapon());

		player.LevelUp();
		Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");

		Player player2 = new Player(); // 오류 안남!
		// Actor 클래스 : 부모 클래스 / Player 클래스 : 자식 클래스

		Debug.Log(player2.Move());
	}

	// 7. 함수 (메소드) : 기능을 편리하게 사용하도록 구성된 영역
	int Heal1(int currentHealth)
	{
		currentHealth += 10;
		Debug.Log("힐을 받았습니다. " + currentHealth);
		return currentHealth; // 함수가 값을 반환할 때 사용
	}

	void Heal2()
	{
		health1 += 10;
		Debug.Log("힐을 받았습니다. " + health1);
	}

	string Battle(int monsterLevel)
	{
		string result;
		if (level >= monsterLevel)
			result = "이겼습니다.";
		else
			result = "졌습니다.";
		return result;
	}
}

