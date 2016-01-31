using UnityEngine;
using System.Collections;

public class Bush : MonoBehaviour {

    public Sprite full;
    public Sprite empty;
    public Sprite Hidden;
    public Sprite Hiddenfull;

    public GameObject target;

    public int value = 5;
    public bool berries = true;
    public bool ishiding = false;

    private SpriteRenderer spriteRenderer;

    Animator anim;


	void Start ()
    {
        anim = GetComponent<Animator>();
        //anim.SetBool("berries", true);
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
        //Debug.Log("pick");
        if (berries == true && ishiding == false)
        {
           // Debug.Log("there are berries");
            berries = false;
            anim.SetBool("berries", false);
            spriteRenderer.sprite = empty;
            target.SendMessage("resourcecollect", value);
        }
    }



    void hidden(bool check)
    {
        if (check == true)
        {
            ishiding = true;
            if (berries == true)
            {
                spriteRenderer.sprite = Hiddenfull;
                anim.SetBool("hidden", true);
            }
            else
            {
                spriteRenderer.sprite = Hidden;
                anim.SetBool("hidden", true);

            }
        }

        if (check == false)
        {
            ishiding = false;
            if (berries == true)
            {
                spriteRenderer.sprite = full;
                anim.SetBool("hidden", false);

            }
            else
            {
                spriteRenderer.sprite = empty;
                anim.SetBool("hidden", false);

            }
        }
    }
}
