using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
	public float timePassed;
	[SerializeField] Image image;

	private spawner spawner;

	private void Start()
	{
		spawner = FindObjectOfType<spawner>();
		StartCoroutine(Timer());
	}

	public IEnumerator Timer()
	{
		while (true)
		{
			yield return new WaitForSeconds(1f);
			timePassed += 1f;
			image.fillAmount = 1- timePassed/spawner.levelTime;

			if (timePassed == spawner.levelTime)
			{
				FindObjectOfType<end>().GameOver(true);
				spawner.End();
			}
		}
	}
}
