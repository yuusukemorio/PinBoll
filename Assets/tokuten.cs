using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tokuten : MonoBehaviour {

    private int T = 0;
    private GameObject T123;

    void Start() {
        this.T123 = GameObject.Find("tokuten");
    }

    void Update() {
        
        this.T123.GetComponent<Text>().text = T.ToString();

    }
        void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "SmallCloudTag") {
            T = T + 10; }

        if (other.gameObject.tag == "LargeCloudTag") {
            T = T + 20; }

        if (other.gameObject.tag == "LargeStarTag")
        {
            T = T + 25;
        }

    }
    }