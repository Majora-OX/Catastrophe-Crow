using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField] private Animator myAnimationController;
    [SerializeField] private GameObject Shadow;
    public float Xspeed = 1;
    public float Yspeed = 1;
    public float Zspeed = 1;
    public AudioClip COIN_COLLECT;
    Vector3 temp;
    public AudioSource collect;
    public GameObject COINUIHOLD;
    public Animator UICOIN;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collect.PlayOneShot(COIN_COLLECT);
            myAnimationController.SetBool("collected", true);
            Shadow.SetActive(false);
            UICOIN.SetTrigger("SPEEN");
            COINUIHOLD.GetComponent<COINCOUNTER>().collected();
            temp = transform.localScale;

            temp.x += (Time.deltaTime * Xspeed);
            temp.y += (Time.deltaTime * Yspeed);
            temp.z += (Time.deltaTime * Zspeed);

            transform.localScale = temp;
        }

    }

    void Update()
    {
        if (myAnimationController.GetCurrentAnimatorStateInfo(0).IsName("CoinSparkleOver"))
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }


}
}


