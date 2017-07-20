#pragma once

#using <System.dll>
#include <cliext/set>
#include <cliext/deque>
#include "ManagedGraph.h"
#include "ManagedNode.h"

using namespace System::Runtime::InteropServices;

namespace Library
{
	class IPathFinder;

	namespace Cli
	{
		public enum class PathFindType
		{
			BFS,
			GreedyBreadthFirst,
			Dijkstra,
			AStar
		};

		public ref class PathFinder sealed
		{
		public:
			PathFinder(PathFindType type);
			System::Collections::Generic::ICollection<ManagedNode^>^ FindPath(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end);
			System::Collections::Generic::ICollection<ManagedNode^>^ FindPathA(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end, [Out] System::Collections::Generic::ICollection<ManagedNode^>^% closedSet);

		private:
			Library::IPathFinder* mPathFinder;
		};
	}
}