public class Actor
{
	// 8. Ŭ���� : �ϳ��� �繰(������Ʈ)�� �����ϴ� ����
	// class : Ŭ���� ���� ���

	// private : �ܺ� Ŭ������ ������� �����ϴ� ������
	// public : �ܺ� Ŭ������ ������ �����ϴ� ������
	// protected : ���� Ŭ���� Ȥ�� �ڽ� Ŭ���������� ���� ������ ������

	public int id;
	public string name;
	public string title;
	public string weapon;
	public float strength;
	public int level;

	public string Talk()
	{
		return "��ȭ�� �ɾ����ϴ�.";
	}

	public string HasWeapon()
	{
		return weapon;
	}

	public void LevelUp()
	{
		level = level + 1;
	}
}
