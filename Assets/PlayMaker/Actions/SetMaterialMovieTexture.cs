﻿// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

#if !(UNITY_IPHONE || UNITY_ANDROID || UNITY_FLASH || UNITY_PS3)

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a named texture in a game object's material to a movie texure.")]
	public class SetMaterialMovieTexture : FsmStateAction
	{
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;
		
		[UIHint(UIHint.NamedTexture)]
		[Tooltip("A named texture in the shader.")]
		public FsmString namedTexture;

		[RequiredField]
		[ObjectType(typeof(MovieTexture))]
		public FsmObject movieTexture;

		public override void Reset()
		{
			gameObject = null;
			materialIndex = 0;
			material = null;
			namedTexture = "_MainTex";
			movieTexture = null;
		}

		public override void OnEnter()
		{
			DoSetMaterialTexture();
			Finish();
		}

		void DoSetMaterialTexture()
		{
			var movie = movieTexture.Value as MovieTexture;

			var namedTex = namedTexture.Value;
			if (namedTex == "") namedTex = "_MainTex";

			if (material.Value != null)
			{
				material.Value.SetTexture(namedTex, movie);
				return;
			}

			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null)
			{
				return;
			}

			if (go.GetComponent<Renderer>() == null)
			{
				LogError("Missing Renderer!");
				return;
			}

			if (go.GetComponent<Renderer>().material == null)
			{
				LogError("Missing Material!");
				return;
			}


			if (materialIndex.Value == 0)
			{
				go.GetComponent<Renderer>().material.SetTexture(namedTex, movie);
			}
			else if (go.GetComponent<Renderer>().materials.Length > materialIndex.Value)
			{
				var materials = go.GetComponent<Renderer>().materials;
				materials[materialIndex.Value].SetTexture(namedTex, movie);
				go.GetComponent<Renderer>().materials = materials;
			}
		}
	}
}

#endif