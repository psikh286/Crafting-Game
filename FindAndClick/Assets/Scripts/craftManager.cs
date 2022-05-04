using UnityEngine;
using System;

public class craftManager : MonoBehaviour
{
    [SerializeField] private slot[] slots;
    [SerializeField] private string[] recieps;
    [SerializeField] private GameObject[] craftableItems;

    [SerializeField] private GameObject resultSlot;

    public void Craft()
	{
        string _result = "";

        foreach (slot i in slots)
		{
            if (i.currentItem != null)
			{
                _result += i.currentItem.GetComponent<drag>().id;
            }            
		}

        int j = -1;

        foreach (string s in recieps)
		{
            j++;
            if (s == _result)
			{
                Instantiate(craftableItems[j], resultSlot.GetComponent<RectTransform>().position, Quaternion.identity, FindObjectOfType<Canvas>().transform);
                
                foreach (slot g in slots)
				{
                    Destroy(g.currentItem);
				}
            }
		}       
    }
}
