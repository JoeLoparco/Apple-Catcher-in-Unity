using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPreFab;
    public int numBaskets = 3;
    public float basketBottmY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numBaskets; i ++){
            GameObject tBasketGO = Instantiate<GameObject> (basketPreFab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottmY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

}
