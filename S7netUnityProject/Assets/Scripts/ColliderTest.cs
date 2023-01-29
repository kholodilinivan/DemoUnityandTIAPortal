using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    public int grab = 2;
    public GameObject anim;
    private Animator getAnim;
    Collider CollidedWith;
    // Start is called before the first frame update
    void Start()
    {
        getAnim = anim.GetComponent<Animator>();
        getAnim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GrabObj()
    {
        StartCoroutine(TestCoroutineStart());
    }

    public void ReleaseObj()
    {
        StartCoroutine(TestCoroutineStop());
    }

    private void OnTriggerEnter(Collider other)
    {
        CollidedWith = other;
        print(other);
    }

    IEnumerator TestCoroutineStart()
    {
        grab = 2;
        getAnim.speed = 1f;
        yield return new WaitForSeconds(3.7f);
        getAnim.speed = 0f;
        if (CollidedWith != null)
        {
            CollidedWith.GetComponent<Rigidbody>().isKinematic = true;
            CollidedWith.transform.parent = this.transform;
        }
    }

    IEnumerator TestCoroutineStop()
    {
        grab = 2;
        getAnim.StartPlayback();
        getAnim.speed = -1f;
        yield return new WaitForSeconds(3.7f);
        if (CollidedWith != null)
        {
            CollidedWith.transform.parent = null;
            CollidedWith.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(CollidedWith.gameObject);
            GameObject Proceed_ = GameObject.Find("PLC_Mode");
            MainProgRobotControl Proceed = Proceed_.GetComponent<MainProgRobotControl>();
            Proceed.RobotProceed(false,true);
        }
        getAnim.speed = 0f;
    }
}