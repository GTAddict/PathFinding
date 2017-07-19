#pragma once

#using <System.dll>
#include <cliext/set>
#include <cliext/deque>

namespace Library
{
	class IPathFinder;
	ref class ManagedNode;
	ref class ManagedGraph;

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
			void FindPath(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end);
			// void FindPathA(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end);
			/*cliext::deque<ManagedNode>*/

		private:
			Library::IPathFinder* mPathFinder;
		};
	}
}