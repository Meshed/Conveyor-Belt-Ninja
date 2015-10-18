using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory(ActionCategory.Math)]
[HutongGames.PlayMaker.Tooltip("Determine if a value is a multiple of another value")]
public class IsMultipleOf : FsmStateAction
{
	[UIHint(UIHint.FsmInt)]
	[RequiredField]
	[HutongGames.PlayMaker.Tooltip("Value to determine if it is a multiple")]
	public FsmInt compareValue;

	[UIHint(UIHint.FsmInt)]
	[RequiredField]
	[HutongGames.PlayMaker.Tooltip("Multiple value")]
	public FsmInt multipleValue;

	[UIHint(UIHint.FsmBool)]
	[RequiredField]
	[HutongGames.PlayMaker.Tooltip("True if multiple, False if not")]
	public FsmBool result = false;

	// Code that runs on entering the state.
	public override void OnEnter()
	{
		int remainder;
		
		if (compareValue.Value > 0) {
			remainder = compareValue.Value % multipleValue.Value;
			
			if(remainder == 0)
			{
				result.Value = true;
				Finish();
			}
		}

		Finish();
	}
}
