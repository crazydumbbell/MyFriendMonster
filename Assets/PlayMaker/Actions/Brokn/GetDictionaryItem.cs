using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Brokn")]
	public class GetDictionaryItem : FsmStateAction
	{

		public FsmString SearchForThisKey;
		public FsmInt Cost;
		public FsmFloat Health;
		public FsmString Weapon;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			DictionaryItem D =  OurDictionary.OurMainDictionary[SearchForThisKey.Value];
			Cost.Value = D.Cost;
			Health.Value = D.Health;
			Weapon.Value = D.Weapon;







			Finish();
		}


	}

}
