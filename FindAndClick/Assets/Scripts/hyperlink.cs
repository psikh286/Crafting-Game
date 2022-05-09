using UnityEngine;

public class hyperlink : MonoBehaviour
{
	[SerializeField] private string url;

	public void OpenLink()
	{
		Application.OpenURL(url);
	}
}
