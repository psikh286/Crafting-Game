using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	[SerializeField] private Transform hierarchy;
	[SerializeField] private GameObject[] items;
	[SerializeField] private GameObject[] randomItems;

	private Canvas canvas;

	private void Start()
	{
		canvas = FindObjectOfType<Canvas>();
		InitialSpawn(3);
		StartCoroutine(Spawn());
	}

	private IEnumerator Spawn()
	{
		int minute = 0;
		while (true)
		{
			if (minute == 60)
			{
				Destroy(hierarchy.gameObject);
				StopAllCoroutines();
			}

			InitialSpawn(1);		

			yield return new WaitForSeconds(5f);
			minute += 5;						
		}		
	}

	private void InitialSpawn(int index)
	{
		for (int i = 0; i < index; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				int r = Random.Range(0, randomItems.Length);
				GameObject item = Instantiate(randomItems[r], canvas.transform.position, Quaternion.identity, hierarchy);

				item.GetComponent<RectTransform>().anchoredPosition += new Vector2(Random.Range(-600f, 200f), Random.Range(-140f, 320f));
			}

			foreach (GameObject j in items)
			{
				GameObject item = Instantiate(j, canvas.transform.position, Quaternion.identity, hierarchy);

				item.GetComponent<RectTransform>().anchoredPosition += new Vector2(Random.Range(-600f, 200f), Random.Range(-140f, 320f));
			}
		}
	}
}
