using UnityEngine;
using System.Collections;

public class interactionTest : MonoBehaviour {

    public bool selectable = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider c)
    {
        if (selectable)
        {

            if (c.gameObject.tag.Equals("Player"))
            {
                GetComponent<Animator>().SetTrigger("Fall");
            }
        }
    }
}
