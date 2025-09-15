using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
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

    [ContextMenu("Quest Tower")]
    public void SolveQuestTower()
    {
        foreach (var rock in Rocks)
        {
            rock.SetActive(true);
        }
    }
}

