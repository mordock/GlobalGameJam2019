using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private Text myText;

    public static int totalPoints;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GainPoints(int points) {
        totalPoints += points;
        myText.text = totalPoints.ToString();
    }
}
