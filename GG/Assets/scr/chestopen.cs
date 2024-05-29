using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestopen : UsingObjects
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void open()
    {
        base.open();
        animationController.SetTrigger("open");
    }

    protected override void close()
    {
        base.close();
        animationController.SetTrigger("close");
    }
    
}