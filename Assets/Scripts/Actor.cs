public class Actor
{
	// 8. 클래스 : 하나의 사물(오브젝트)와 대응하는 로직
	// class : 클래스 선언에 사용

	// private : 외부 클래스에 비공개로 설정하는 접근자
	// public : 외부 클래스에 공개로 설정하는 접근자
	// protected : 같은 클래스 혹은 자식 클래스에서만 접근 가능한 접근자

	public int id;
	public string name;
	public string title;
	public string weapon;
	public float strength;
	public int level;

	public string Talk()
	{
		return "대화를 걸었습니다.";
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
