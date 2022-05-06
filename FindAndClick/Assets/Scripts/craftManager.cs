using UnityEngine;
using System;

public class craftManager : MonoBehaviour
{
    [SerializeField] private GameObject resultSlot;
    [SerializeField] private swaper swaper;
    [SerializeField] private Transform hierarchy;

    [SerializeField] private slot[] slots;
    [SerializeField] private string[] recieps;
    [SerializeField] private GameObject[] craftableItems;    

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

        Debug.Log(_result);
        int j = -1;

        foreach (string s in recieps)
		{
            j++;
            if (s == _result)
			{
                Instantiate(craftableItems[j], resultSlot.GetComponent<RectTransform>().position, Quaternion.identity, hierarchy);
                swaper.Swap();
                
                foreach (slot g in slots)
				{
                    Destroy(g.currentItem);
				}
            }
		}       
    }
}
