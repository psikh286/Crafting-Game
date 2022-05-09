using UnityEngine;
using UnityEngine.EventSystems;

public class tutorial : MonoBehaviour, IPointerDownHandler
{

	[SerializeField] private GameObject mask;
	[SerializeField] private drag drag;


	public void OnPointerDown(PointerEventData eventData)
	{
		mask.SetActive(false);
	}


	public void OnEndDrag(PointerEventData eventData)
	{
		drag.OnEndDrag(eventData);
		drag.enabled = false;
	}
}
