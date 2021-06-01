using System;

namespace _2D_Editor
{
	public interface ICommand
	{
		void Redo();

		void Undo();
	}
}
