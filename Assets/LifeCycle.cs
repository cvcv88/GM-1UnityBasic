using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
	/* Unity LifeCycle */

	// �ʱ�ȭ �ܰ�(����)
	// - Awake() ���� ������Ʈ ������ ��, ���� ����
	// - Start() �������� ���� ����, ���� ����
	private void Awake()
	{
		Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
	}

	private void Start()
	{
		Debug.Log("��� ��� ì����ϴ�.");
	}

	// ���� + ���ӷ��� = ������
	// ���� ���� �ܰ�(����)
	// - FixedUpdate() ���� ���� ������Ʈ, 1�ʿ� 50�� ����, ������ ���� �ֱ�� ^CPU�� ���� ���^
	private void FixedUpdate()
	{
		Debug.Log("�̵�~");
	}

	// ���� ���� �ܰ�(����)
	// - Update() ���� ���� ������Ʈ, ���� ������ ������ ������, �ֱ������� ���ϴ� ������ ���� �� ���, ȯ�濡 ���� ^���� �ֱⰡ ������ �� �ִ�^
	// - LateUpdate() ��� ������Ʈ ���� ��, ĳ���͸� ���󰡴� ī�޶�, ������ ��ó�� �� �� ��� ��
	private void Update()
	{
		Debug.Log("���� ���!!");
	}

	private void LateUpdate()
	{
		Debug.Log("����ġ ȹ��~!");
	}

	// ��ü �ܰ�(����)
	// - OnDestroy() ���� ������Ʈ�� ������ ��
	private void OnDestroy()
	{
		Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
	}

	// Ȱ��ȭ �ܰ�(����) : �ʱ�ȭ <- Ȱ��ȭ -> ����
	// - OnEnable() ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��, ���� 1ȸ ������ �ƴ� �Ѱ� �������� ����
	private void OnEnable()
	{
		Debug.Log("�÷��̾ �α����߽��ϴ�.");
	}

	// ��Ȱ��ȭ �ܰ�(����) : ���� ���� <- ��Ȱ��ȭ -> ��ü
	// - OnDisable() ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
	private void OnDisable()
	{
		Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
	}
}
