using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject options_menu, go_menu,vr;
    private bool is_active;
    public Rigidbody2D rig2d;
    void Start()
    {
        is_active=false;
        if (options_menu != null)
        {
            options_menu.SetActive(is_active);
        }
        if (go_menu != null)
        {
            go_menu.SetActive(is_active);
        }
        if (vr != null)
        {
            vr.SetActive(is_active);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void show_options()
    {
        if (rig2d.velocity.y < 0.1f && rig2d.velocity.y > -0.1f)
        {

            is_active = !is_active;
            if (options_menu != null)
            {
                options_menu.SetActive(is_active);
            }
            if (go_menu != null)
            {
                go_menu.SetActive(is_active);
            }
            if (vr != null)
            {
                vr.SetActive(is_active);
            }
        }
    }
}
