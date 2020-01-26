using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusionMonsterManager : MonoBehaviour
{
    [SerializeField] float init = 5f;
    [SerializeField] float timeInBetween = 1.5f;

    private GameObject Monsters;
    private int currentChild = 0;
    private GameObject[] childs;
    // Start is called before the first frame update

    private void Awake() {
        Monsters = GameObject.Find("Monsters");
        childs = new GameObject[Monsters.transform.childCount];

        // Disable
        for(int i = 0; i < Monsters.transform.childCount; i++){
            childs[i] = Monsters.transform.GetChild(i).gameObject;
            childs[i].SetActive(false);
        }
    }
    void Start()
    {
        Invoke("SetChildActive", init + timeInBetween * 0);
        Invoke("SetChildActive", init + timeInBetween * 1);
        Invoke("SetChildActive", init + timeInBetween * 2);
        
    }

    void SetChildActive() {
        childs[currentChild].SetActive(true);

        currentChild++;
    }
}
