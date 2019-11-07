using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {



    private GameObject scoreText;

    private int total = 0;

    private string score;

    
  
       

    // Use this for initialization
    void Start () {

        this.scoreText = GameObject.Find("Score");    
		
	}
	
	// Update is called once per frame
	void Update () {

     
	}

    void OnCollisionEnter(Collision other)
    {

            if (other.gameObject.tag == "SmallStarTag")
            {
                this.total += 55;
            }
            else if (other.gameObject.tag == "LargeStarTag")
            {
                this.total += 10;
            }
            else if (other.gameObject.tag == "LargeCloudTag")
            {
                this.total += 5;
            }
            else if (other.gameObject.tag == "SmallCloudTag")
            {
                this.total += 2;
            }
        if (other.gameObject.tag != "Untagged" && (other.gameObject.tag != "LeftFripperTag"  && other.gameObject.tag != "RightFripperTag") )
        {

            Debug.LogFormat("Score: " + total.ToString());
            this.scoreText.GetComponent<Text>().text = total.ToString();
        }


    }




}
