using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IA.StateMachine
{
	public class Transition
	{
		public SMAction action { get; set; }

		public State targetState { get; set; }

		public TestTransition IsTriggered { get; set; }

	}
	public delegate bool TestTransition();
}