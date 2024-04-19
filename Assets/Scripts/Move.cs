using UnityEngine;

public class Move : MonoBehaviour
{
	Vector3 target = new Vector3(0, 1f, 6);

	void Update()
	{
		// 1. MoveTowars : ��� �̵�(������ �̵�), (������ġ, ��ǥ��ġ, �ӵ�)
		// transform.position = Vector3.MoveTowards(transform.position, target, 1f);

		// 2. SmoothDamp : �ε巯�� ���� �̵�, (������ġ, ��ǥ��ġ, �����ӵ�, �ӵ�)
		Vector3 velo = Vector3.zero;
		// transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);

		// 3. Lerp : ���� ����, SmoothDamp���� ���ӽð��� ��
		// ������ �Ű������� ����Ͽ� �ӵ� ���� (�ִ밪 1)
		// transform.position = Vector3.Lerp(transform.position, target, 0.1f);

		// 3. Slerp : ���� ���� ����, ȣ�� �׸��� �̵�
		transform.position = Vector3.Slerp(transform.position, target, 0.05f);
	}
}
