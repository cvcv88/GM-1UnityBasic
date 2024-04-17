using System.Collections.Generic;
using UnityEngine;

public class CSharpProgrammingBasic1 : MonoBehaviour
{
	private void Start()
	{
		// 1. ����
		// ���� : �����͸� �޸𸮿� �����ϴ� ���
		// int float string bool
		int level = 5;                  // ������ ������
		float strength = 15.5f;         // ����(�Ǽ�)�� ������, �ڿ� f �� �ٿ��ֱ�
		string playerName = "�����׸�";  // ���ڿ� ������
		bool isFullLevel = false;       // ���� ������

		// �ڷ����� �������� �ۼ��ϴ� ���� ����
		// ���� �ִ� ���� �ʱ�ȭ

		// ���� > �ʱ�ȭ > ȣ��(���)

		Debug.Log("����� �̸���?");
		Debug.Log(playerName);
		Debug.Log("����� ������?");
		Debug.Log(level);
		Debug.Log("����� ����?");
		Debug.Log(strength);
		Debug.Log("���� �����ΰ�?");
		Debug.Log(isFullLevel);

		// 2. �׷������� : �������� ���� �ϳ��� ���
		// string monsters = "������", "�縷��", "�Ǹ�"; -> error!
		// �迭 : ���� �⺻���� ������ �׷��� ����
		string[] monsters = { "������", "�縷��", " �Ǹ�" };
		Debug.Log("�ʿ� �����ϴ� ����");
		Debug.Log(monsters[0]); // 
		Debug.Log(monsters[1]);
		Debug.Log(monsters[2]);

		int[] monsterLevel = new int[3]; // ���ο� �迭�� ����ٴ� ���� new, �迭�� ũ�� 3
		monsterLevel[0] = 1;
		monsterLevel[1] = 6;
		monsterLevel[2] = 20;
		Debug.Log("�ʿ� �����ϴ� ������ ����");
		Debug.Log(monsterLevel[0]); // 
		Debug.Log(monsterLevel[1]);
		Debug.Log(monsterLevel[2]);

		// List<type> items = new List<type>();
		// <> : Generic(���׸�)
		List<string> items = new List<string>();
		items.Add("������30");
		items.Add("��������30");
		items.Add("���ݷ¹���");

		items.RemoveAt(0); // ����� ���� ������ ���� ��

		Debug.Log("������ �ִ� ������");
		Debug.Log(items[0]);
		Debug.Log(items[1]);
		// Debug.Log(items[2]); // ũ�⸦ ��� Ž���� ������ �߻�

		// 3. ������ : ���, �������� �������ִ� ��ȣ
		int exp = 1500;

		exp = 1500 + 320;
		exp = exp - 10;
		level = exp / 300;
		strength = level * 3.1f;

		Debug.Log("����� �� ����ġ��?");
		Debug.Log(exp);
		Debug.Log("����� ������?");
		Debug.Log(level);
		Debug.Log("����� ����?");
		Debug.Log(strength);

		int nextExp = 300 - (exp % 300); // % ���� �ƴ� �������� ���
		Debug.Log("���� �������� ���� ����ġ��?");
		Debug.Log(nextExp);

		string title = "������";
		Debug.Log("����� �̸���?");
		Debug.Log(title + " " + playerName);


		int fullLevel = 99;
		isFullLevel = level == fullLevel; // level�� fullLevel�� ������ ��
		Debug.Log("���� �����Դϱ�? " + isFullLevel);

		bool isEndTutorial = level >= 10; // level�� 10���� ���ų� ū�� ��
		Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);

		int health = 30;
		int mana = 25;
		bool isBadCondition = health <= 50 && mana <= 20; // && �� ���� ��� true�� ���� true ���
		Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

		mana = 15;
		isBadCondition = health <= 50 && mana <= 20;
		Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

		mana = 25;
		isBadCondition = health <= 50 || mana <= 20; // || �� �� �߿��� �ϳ��� true�� true ���
		Debug.Log("����� ���°� ���޴ϱ�? " + isBadCondition);

		// ? A : B true�� �� A, false�� �� B ���
		string condition = isBadCondition ? "����" : "����";
		Debug.Log("����� ���°� ���޴ϱ�? " + condition);

		// 4. Ű���� : ���α׷��� �� �����ϴ� Ư���� �ܾ�
		// int float = 1.f;
		// string name = List;
		// int float string bool new List
	}
}
