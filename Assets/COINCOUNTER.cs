using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COINCOUNTER : MonoBehaviour
{
    private float coinsCollected = 00;
    public GameObject Char1;
    public GameObject Char2;
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void collected()
    {
        if (coinsCollected == 0) {
            anim.enabled = true;
        }
        coinsCollected++;
       
       
        if(coinsCollected.ToString().Length > 1)
        {
           
            Char1.GetComponent<Image>().sprite = Resources.Load<Sprite>("Coins/" + coinsCollected.ToString()[0]);
            Char2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Coins/" + coinsCollected.ToString()[1]);
        }
        else { Char2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Coins/" + coinsCollected.ToString()); }
    }
}
