using UnityEngine;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler
{
	public GameObject currentItem;

	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null)
		{
			currentItem = eventData.pointerDrag;
			currentItem.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
			currentItem.GetComponent<drag>()._slot = this;
		}
	}
}
