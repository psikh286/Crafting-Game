using UnityEngine;
using UnityEngine.EventSystems;

public class cantDrop : MonoBehaviour, IDropHandler
{
	public static Vector2 selectedItem;
	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null)
		{
			eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = selectedItem;
		}
	}
}
