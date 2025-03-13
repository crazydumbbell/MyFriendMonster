using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Brokn")]
	public class AddNewItem : FsmStateAction
	{
		public FsmString Name;
		public FsmInt Cost;
		public FsmFloat Health;
		public FsmString Weapon;

		
		public override void OnEnter()
		{
			DictionaryItem D = new DictionaryItem();
			D.Cost = Cost.Value;
			D.Health = Health.Value;
			D.Weapon = Weapon.Value;
			D.Name = Name.Value;

			OurDictionary.OurMainDictionary.Add(Name.Value, D);


			Finish();
		}


	}

}
