using UnityEngine;

public class InputScript2 : MonoBehaviour
{
	// Transform : ������Ʈ ���¿� ���� �⺻ ������Ʈ
	// position, rotation, scale
	// ������Ʈ�� ���� transform�� �׻� ������ ����. �ʱ�ȭ �� �ʿ� ����.

	private void Start()
	{
		// Vector ����
		int number = 4; // ��Į�� �� : ������ ��
		Vector3 vec = new Vector3(2, 2, 2); // ����� �׿� ���� ũ�� ��

		// Transflate : ���� ���� ���� ��ġ�� ���ϴ� �Լ�
		// transform.Translate(vec);
	}

	private void Update()
	{
		// Vector3 vec = new Vector3(0, 0.1f, 0);
		Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.Translate(vec);
	}
}
