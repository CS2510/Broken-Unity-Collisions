using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject PaintBall;
    public GameObject Player;
    int ticks = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ticks++;
        if(ticks%100 == 0)
        {
            var NewPaintBall = Instantiate(PaintBall, Player.transform.position + Player.transform.forward + Player.transform.up, Quaternion.identity);
            NewPaintBall.GetComponent<Rigidbody>().AddForce(Player.transform.forward * 2000);
            Destroy(NewPaintBall, 10);
        }
        
    }
}
