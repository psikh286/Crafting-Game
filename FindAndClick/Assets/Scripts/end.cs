using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class end : MonoBehaviour
{
    public int itemsDone = -1;

	[SerializeField] private GameObject gameoverMenu;
	[SerializeField] private spawner spawner;

	[SerializeField] private Canvas canvas;

	[SerializeField] private TextMeshProUGUI timeText;
	[SerializeField] private TextMeshProUGUI itemsText;

	public void GameOver(bool timesUp)
	{
		gameoverMenu.SetActive(true);
		timer _timer = FindObjectOfType<timer>();
		_timer.StopAllCoroutines();
		spawner.End();

		Transform[] children = canvas.GetComponentsInChildren<Transform>();		

		foreach (Transform i in children)
		{
			if (i.gameObject.tag != "Finish")
			{
				i.gameObject.SetActive(false);
			}
		}

		itemsText.text = "Items done: " + itemsDone;

		timeText.text = "Time: " + _timer.timePassed.ToString("F0") + "s";
		
	}
}
