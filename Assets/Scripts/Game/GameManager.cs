using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public int totalItemCount; // 맵에 존재하는 아이템 개수 총합
	public int stage; // 현재 스테이지 번호
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
