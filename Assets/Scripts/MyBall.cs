using UnityEngine;

public class MyBall : MonoBehaviour
{
	// ���� �ʱ�ȭ ȣ��
	Rigidbody rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		// �ش� ��ũ��Ʈ�� ���� ���� ������Ʈ�� Rigidbody ������Ʈ�� �����´�.
		// GetComponent<T> : �ڽ��� TŸ�� ������Ʈ�� ������.

		// velocity : ���� �̵� �ӵ�

		// �ѹ��� ���� �����ְ� ����
		// rigid.velocity = Vector3.right;
		// rigid.velocity = new Vector3(2, 4, 3);
	}

	private void FixedUpdate()
	{
        // ����ؼ� Update �Ǹ鼭 �ӵ� ����
        // rigid.velocity = Vector3.right; // �ӷ� �ٲٱ�
        // rigid.velocity = new Vector3(2, 4, 3);

        // if (Input.GetButtonDown("Jump"))
        // {
			// ForceMode : ���� �ִ� ���(����, ���� �ݿ�)
			// rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
		// }

		Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		rigid.AddForce(vec, ForceMode.Acceleration);
		// Rigidbody�� �̿��� �̵��� ���� �ڿ�������.

		// ȸ����, AddTorque(Vec) : Vec ������ ������ ȸ������ ����
		// rigid.AddTorque(Vector3.back);
		// rigid.AddTorque(Vector3.up);
	}

	// ������ �浹 X, �ݶ��̴����� ���ƴ��� �� �� �ϳ��� ������ Trigger���� ��
	private void OnTriggerStay(Collider other)
	{
		if(other.name == "JumpCube")
			rigid.AddForce(Vector3.up, ForceMode.Impulse);
	}

	public void Jump()
	{
		rigid.AddForce(Vector2.up * 5, ForceMode.Impulse);
	}
}
