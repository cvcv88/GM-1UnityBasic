using TMPro;
using UnityEngine;

public class GameDateManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI stageItemCountText;
	[SerializeField] TextMeshProUGUI curItemCountText;
	[SerializeField] int stageItemCount;
	public int score;

	public void Start()
	{
		stageItemCountText.text = stageItemCount.ToString();
	}

	public void GetItem()
	{
		score++;
		curItemCountText.text = score.ToString();
	}
}
