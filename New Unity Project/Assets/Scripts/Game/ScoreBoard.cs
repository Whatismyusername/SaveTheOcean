using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    Text text;
    private float score = 0;
    [SerializeField] float scorePerSecond = 2f;
    [SerializeField] float scorePerHit = 5f;
    [SerializeField] float scorePerKill = 20f;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scorePerSecond;
        text.text = ((int)score).ToString();
    }

    public void ScorePerHit() {
        score += scorePerHit;
    }
    
    public void ScorePerKill() {
        score += scorePerKill;
    }
}
