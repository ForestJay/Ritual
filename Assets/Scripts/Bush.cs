using UnityEngine;
using System.Collections;

public class Bush : MonoBehaviour {

    public Sprite full;
    public Sprite empty;
    public Sprite Hidden;
    public Sprite Hiddenfull;

    public GameObject target;

    public bool berries = true;
    public bool ishiding = false;

    private SpriteRenderer spriteRenderer;

	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = full;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
        }
    }

    void pick()
    {
        Debug.Log("pick");
        if (berries == true)
        {
            Debug.Log("there are berries");
            berries = false;
            spriteRenderer.sprite = empty;
            target.SendMessage("resourcecollect", 5);
        }
    }



    void hidden(bool check)
    {
        if (check == true)
        {
            if (berries == true)
            {
                spriteRenderer.sprite = Hiddenfull;
            }
            else
            {
                spriteRenderer.sprite = Hidden;
            }
        }

        if (check == false)
        {
            if(berries == true)
            {
                spriteRenderer.sprite = full;
            }
            else
            {
                spriteRenderer.sprite = empty;
            }
        }
    }
}
