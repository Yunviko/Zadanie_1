using UnityEngine;

public class ColorChangeOnContact : MonoBehaviour
{
    public bool Epreesed = false;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Epreesed = true;
            animator.SetBool("square", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        { 
            Epreesed = false;
            animator.SetBool("square", false);
        }
    }



}