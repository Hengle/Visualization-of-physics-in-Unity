﻿/* MIT License
Copyright (c) 2017 Uvi Vagabond, UnityBerserkers
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityBerserkersGizmos;

[ExecuteInEditMode]
public class Box2DRayCast : MonoBehaviour
{

	[SerializeField]Vector3 origin;
	[SerializeField]Vector3 direction;
	[SerializeField]float distance = 1;
	RaycastHit2D hitByRayCast;
	[Space (55)][Header ("Results:")]
	[SerializeField]bool isSomethingHit;

	void Update ()
	{		
		isSomethingHit = Physics2D.Raycast (origin: origin, direction: direction, distance: distance,			
			layerMask: Physics2D.DefaultRaycastLayers, minDepth: -Mathf.Infinity, maxDepth: Mathf.Infinity);
	}

	void OnDrawGizmos ()
	{
		GizmosForPhysics2D.DrawRayCast (origin: origin, direction: direction, distance: distance,
			layerMask: Physics2D.DefaultRaycastLayers, minDepth: -Mathf.Infinity, maxDepth: Mathf.Infinity);
	}
}
