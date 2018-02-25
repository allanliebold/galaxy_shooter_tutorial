using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  //public or private identify
  //data type - int, floats, bool, strings
  
  public float speed;
  
  void Start () {
    //Debug.Log(transform.position);
    transform.position = new Vector3(0, 0, 0);
  }
  
  void Update () {
    transform.Translate(new Vector3.right * Time.deltaTime * 20);
  }

}
