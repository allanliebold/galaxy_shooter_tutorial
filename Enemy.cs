using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
  
    void Update () {
      // If other is laser, destroy this
        
      // If other is player, damage or kill player
    }
    
    void Movement () {
        // move down
        // move left and right    
    }
    
    void Death () {
        
    }
    
    void KillPlayer() {
        // collide with player, call player.Death()
        // and destroy enemy object
    }
}
