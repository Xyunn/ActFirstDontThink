﻿using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public ActionObject m_trap;

	void Start () {
        m_trap = FindObjectOfType<ActionObject>();
	}
	
    public void onClick()
    {
        m_trap.activate();
    }
}