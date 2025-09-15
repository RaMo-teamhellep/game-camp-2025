using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    public GameObject[] Rocks;
    
    // Start is called before the first frame update
    private void Start()
    {
        foreach (var rock in Rocks)
        {
            rock.SetActive(false);
        }
    }

    [ContextMenu("Solve Quest")]
    private void SolveQuest()
    {
        foreach (var rock in Rocks)
        {
            rock.SetActive(true);
        }
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Quest Tower solved!");
        SolveQuest();
    }
}
