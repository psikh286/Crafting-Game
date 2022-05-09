using UnityEngine;
using UnityEngine.SceneManagement;

public class travelTo : MonoBehaviour
{
	[SerializeField] private int index;
	public void ChangeScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
	}
}
