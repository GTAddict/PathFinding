#include "pch.h"
#include "PathFinder.h"
#include "ManagedNode.h"
#include "ManagedGraph.h"
#include "ManagedPoint.h"
#include "Node.h"
#include "Point.h"
#include "Graph.h"
#include <assert.h>

using namespace System;
using namespace Library;
using namespace msclr::interop;

namespace Library
{
	namespace Cli
	{
		PathFinder::PathFinder(PathFindType type)
			: mPathFinder(nullptr)
		{
			switch (type)
			{
			case Library::Cli::PathFindType::BFS:					mPathFinder = new BreadthFirstFinder();															break;
			case Library::Cli::PathFindType::GreedyBreadthFirst:	mPathFinder = new GreedyBestFirstFinder(Heuristics::ManhattanDistance);							break;
			case Library::Cli::PathFindType::Dijkstra:				mPathFinder = new DijkstrasFinder(Heuristics::ConstantOneDistance);								break;
			case Library::Cli::PathFindType::AStar:					mPathFinder = new AStarFinder(Heuristics::ManhattanDistance, Heuristics::ConstantOneDistance);	break;
			default:												mPathFinder = nullptr; assert("Unknown path find type.");
			}
		}

		System::Collections::Generic::ICollection<ManagedNode^>^ PathFinder::FindPath(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end)
		{
			auto deck = gcnew cliext::deque<Library::Cli::ManagedNode^>();
			auto retval = mPathFinder->FindPath(graph->UnmanagedGraph->At(start->Location->X, start->Location->Y), graph->UnmanagedGraph->At(end->Location->X, end->Location->Y));

			for (auto val : retval)
			{
				Library::Cli::ManagedNode^ node = graph[val.get()->Location().X(), val.get()->Location().Y()];
				deck->push_back(node);
			}

			return deck;
		}
	}
}