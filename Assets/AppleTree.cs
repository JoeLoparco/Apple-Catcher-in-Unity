using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;

    public GameObject goldenApplePrefab;
    public float speed = 1f; // 1f = 1frame
    
    public float leftAndRightEdge = 10f;

    public float changeDirChance = 0.02f;
    
    public float appleDropDelay = 1f;
    
    //Invoke("DropApple",2f);
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", appleDropDelay);
    }

    void DropApple() {
        if(Random.value > 0.1){
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position; // instaniate apple at apple tree pos
            Invoke("DropApple", appleDropDelay);
        }else{
            GameObject goldenApple = Instantiate<GameObject>(goldenApplePrefab);
            goldenApple.transform.position = transform.position; // instaniate apple at apple tree pos
            Invoke("DropApple", appleDropDelay);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //creates vector 'pos 'to represnt our postion 
        pos.x += speed * Time.deltaTime;// increses x position by speed* time elapsed Makes Game Based
        transform.position = pos; 
        //Changing Direction
        if ( pos.x < -leftAndRightEdge){  // If current x poistion is less than right edge
            speed = Mathf.Abs(speed); // Move Right
        } else if (pos.x > leftAndRightEdge) { // if current x position is less then left edge
            speed = -Mathf.Abs (speed); // Move Left
        }  
        //else if (Random.value < changeDirChance ){
          //  speed *= -1; // Change Direction
        //}
        //Random Change in Direction
    }   

    void FixedUpdate()
    {
        
        if(Random.value < changeDirChance){
            speed *=- 1;
        }
    }
}
