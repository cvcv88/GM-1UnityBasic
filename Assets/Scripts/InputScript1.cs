using UnityEngine;

public class InputScript1 : MonoBehaviour
{
	private void Update()
	{
		// Input : ���� �� �Է��� �����ϴ� Ŭ����
		// anyKeyDown : �ƹ� �Է��� ���ʷ� ���� �� true
		// anyKey : �ƹ� �Է��� ������ true
		// GetKey : Ű���� ��ư �Է��� ������ true / GetKeyDown / GetKeyUp

		if (Input.anyKeyDown)
			Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
		if (Input.anyKey)
			Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

		if (Input.GetKeyDown(KeyCode.Return))
			Debug.Log("�������� �����Ͽ����ϴ�.");
		if (Input.GetKey(KeyCode.LeftArrow))
			Debug.Log("�������� �̵� ��...");
		if (Input.GetKeyUp(KeyCode.RightArrow))
			Debug.Log("������ �̵��� ���߾����ϴ�.");


		// GetMouse : ���콺 ��ư �Է��� ������ true
		// �Ű����� ���ڷ� ����, 0�� 1
		// 0 : ���콺 ���� Ŭ��
		// 1 : ���콺 ������ Ŭ��
		if (Input.GetMouseButtonDown(0))
			Debug.Log("�̻��� �߻�!");
		if (Input.GetMouseButton(0))
			Debug.Log("�̻��� ������ ��...");
		if (Input.GetMouseButtonUp(0))
			Debug.Log("���� �̻��� �߻�!!");

		// GetButton : Input ��ư �Է��� ������ true
		if (Input.GetButtonDown("Jump"))
			Debug.Log("����!");
		if (Input.GetButton("Jump"))
			Debug.Log("���� ������ ��...");
		if (Input.GetButtonUp("Jump"))
			Debug.Log("���� ����!!");


		if (Input.GetButton("Horizontal"))
		{
			Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
			// GetAxis : ����, ���� ��ư �Է��� ������ float
		}

		if (Input.GetButton("Vertical"))
		{
			Debug.Log("�� �̵� ��..." + Input.GetAxis("Vertical"));
		}

		if (Input.GetButton("Horizontal"))
		{
			Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
		}

		if (Input.GetButton("Vertical"))
		{
			Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
		}
	}
}
