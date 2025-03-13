using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Brokn")]
	public class InitDictionary : FsmStateAction
	{

		// Code that runs on entering the state.
		public override void OnEnter()
		{

			var Temp = Resources.LoadAll<DictionaryItem>("Diction");

			foreach(DictionaryItem D in Temp)
			{
				OurDictionary.OurMainDictionary.Add(D.Name, D);
			}


			Finish();
		}


	}

}
