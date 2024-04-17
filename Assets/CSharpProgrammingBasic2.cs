using System.Collections.Generic;
using UnityEngine;

public class CSharpProgrammingBasic2 : MonoBehaviour
{
	private void Start()
	{
		int health = 30;
		int mana = 15;
		bool isBadCondition = health <= 50 && mana <= 20;
		string condition = isBadCondition ? "����" : "����";

		List<string> items = new List<string>();
		items.Add("������30");
		items.Add("��������30");
		items.Add("���ݷ¹���");

		string[] monsters = { "������", "�縷��", " �Ǹ�" };

		// 5. ���ǹ�
		// if : ������ true�� ��, ���� ����
		if (condition == "����")
		{
			Debug.Log("�÷��̾� ���°� ���ڴ� �������� ����ϼ���.");
		}
		else
		{
			Debug.Log("�÷��̾� ���°� �����ϴ�.");
		}

		if (isBadCondition && items[0] == "������30")
		{
			items.RemoveAt(0);
			health += 30;
			Debug.Log("��������30�� ����Ͽ����ϴ�.");
		}
		else if (isBadCondition && items[0] == "��������30")
		{
			items.RemoveAt(0);
			mana += 30;
			Debug.Log("��������30�� ����Ͽ����ϴ�.");
		}

		// switch, case : ������ ���� ���� ���� ����
		switch (monsters[0])
		{
			case "������":
			case "�縷��":
				Debug.Log("���� ���Ͱ� ����!");
				break;
			case "�Ǹ�":
				Debug.Log("���� ���Ͱ� ����!");
				break;
			case "��":
				Debug.Log("���� ���Ͱ� ����!");
				break;
			default:
				Debug.Log("??? ���Ͱ� �⿬!");
				break;
		}


		// 6. �ݺ��� : ���ǿ� �����ϸ� ������ �ݺ��ϴ� ���
		// while : ������ true�϶�, ���� �ݺ� ���
		while (health > 0)
		{
			health--;
			if (health > 0)
				Debug.Log("�� �������� �Ծ����ϴ�. " + health);
			else
				Debug.Log("����Ͽ����ϴ�.");
			
			if(health == 10)
			{
				Debug.Log("�ص����� ����մϴ�.");
				break;
			}
		}

		// for : ������ �����ϸ鼭 ���� �ݺ� ����
		// ���꿡 ����� ���� ; ���� ; ����
		// �׷��� ���� ���� : .Length(�迭) .Count(����Ʈ)
		for (int count = 0; count < 10; count++)
		{
			health++;
			Debug.Log("�ش�� ġ����... " + health);
		}

		for(int index = 0; index < monsters.Length; index++)
		{
			Debug.Log("�� ������ �ִ� ����(for) : " + monsters[index]);
		}

		foreach(string monster in monsters)
		{
			Debug.Log("�� ������ �ִ� ����(foreach) : " + monster);
		}
	}
}
