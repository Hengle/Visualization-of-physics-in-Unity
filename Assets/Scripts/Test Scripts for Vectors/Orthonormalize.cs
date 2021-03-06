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
public class Orthonormalize : MonoBehaviour
{

	[SerializeField]	Vector3 originOfVectors;
	[Space (50)]

	[SerializeField]	Vector3 normal = new Vector3 (0f, 0f, 0f);
	[Space (50)]
	[SerializeField]	Vector3 tangent = new Vector3 (0f, 0f, 0f);
	[SerializeField]	Vector3 binormal = new Vector3 (0f, 1f, 0f);


	[Space (50)]
	[SerializeField]float lenght;

	void Update ()
	{
		Vector3.OrthoNormalize (normal: ref normal, tangent: ref tangent, binormal: ref binormal);
		ShowMoreReadableResults ();
	}

	void OnDrawGizmos ()
	{
		GizmosForVector.VisualizeOrthonormalize (origin: originOfVectors, normal: normal, tangent: tangent, lenght: lenght);
	}

	void ShowMoreReadableResults ()
	{
		normal = normal.Round (2);
		tangent = tangent.Round (2);
		binormal = binormal.Round (2);
	}
}
