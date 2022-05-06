using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IInitializePotentialDragHandler
{
	public slot _slot;
	public string id;

	[SerializeField] private Canvas canvas;

	private RectTransform rectTransform;
	private CanvasGroup canvasGroup;

	private void Awake()
	{
		canvas = FindObjectOfType<Canvas>();
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		transform.SetAsLastSibling();
		if (_slot != null)
		{
			_slot.currentItem = null;
			_slot = null;
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
	}

	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
		eventData.useDragThreshold = false;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		canvasGroup.alpha = 0.6f;
		canvasGroup.blocksRaycasts = false;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;
	}
}
