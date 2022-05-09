using UnityEngine;
using UnityEngine.UI;

public class swaper : MonoBehaviour
{
	public GameObject requiredItem;

	[SerializeField] private Image icon;
	[SerializeField] private end end;
	[SerializeField] private GameObject[] crafteableItems;

	[SerializeField ]private spawner _spawner;


	private void Awake()
	{
		Swap();		
	}

	public void Swap() 
	{
		end.itemsDone++;
		_spawner.levelTime += 3f;

		requiredItem = crafteableItems[Random.Range(0, crafteableItems.Length)];
		icon.sprite = requiredItem.GetComponent<Image>().sprite;		
	}
}
