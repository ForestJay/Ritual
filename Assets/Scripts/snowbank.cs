using UnityEngine;
using System.Collections;

public class snowbank : MonoBehaviour
{

    public Sprite empty;
    public Sprite Hidden;

    public GameObject target;

    public bool ishiding = false;

    private SpriteRenderer spriteRenderer;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("hidden", false);
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = empty;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
        }
    }


    void hidden(bool check)
    {
        if (check == true)
        {
            anim.SetBool("hidden", true);
            spriteRenderer.sprite = Hidden;
        }

        if (check == false)
        {
            anim.SetBool("hidden", false);
            spriteRenderer.sprite = empty;
        }
    }
}
