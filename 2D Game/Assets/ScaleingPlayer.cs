using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleingPlayer : MonoBehaviour
{
    public GameObject rotater;
    void Start () {
       rotater = GameObject.Find("player");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Scaler")
        {
            rotater.gameObject.transform.localScale -= new Vector3(1,1,0);
        }
    }
        private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Scaler")
        {
            rotater.gameObject.transform.localScale += new Vector3(1,1,0);
        }
    }


 

}
