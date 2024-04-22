using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int totalItemCount; // �ʿ� �����ϴ� ������ ���� ����
	public int stage; // ���� �������� ��ȣ
	public TextMeshProUGUI stageCountText;
	public TextMeshProUGUI playerCountText;

	public void Awake()
	{
		stageCountText.text = " / " + totalItemCount;
	}

	public void GetItem(int count)
	{
		playerCountText.text = count.ToString();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene(stage);
	}
}
