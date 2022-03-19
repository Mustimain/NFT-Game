using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseUltimate : MonoBehaviour
{
    public GameObject[] ultimates;


    public void ChooseUlti(int index)
    {
        for (int i = 0; i < ultimates.Length; i++)
        {
            ultimates[i].SetActive(false);
        }

        ultimates[index].SetActive(true);
    }


    public void CloseButton(int index)
    {
        for (int i = 0; i < ultimates.Length; i++)
        {
            ultimates[i].SetActive(false);
        }

    }
}
