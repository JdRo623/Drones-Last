using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IA.StateMachine
{
	public abstract class State
	{
		public Transition[] Transitions { set; get; }

		public abstract void OnEntryAction();
		public abstract void OnUpdateAction();
		public abstract void OnExitAction();

	}
}
