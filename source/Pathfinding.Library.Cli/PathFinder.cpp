#include "pch.h"
#include "PathFinder.h"
#include "ManagedNode.h"
#include "ManagedGraph.h"
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

		void PathFinder::FindPath(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end)
		{
			UNREFERENCED_PARAMETER(graph);
			UNREFERENCED_PARAMETER(start);
			UNREFERENCED_PARAMETER(end);
			// mPathFinder->FindPath(nullptr, nullptr);
		}

		// void PathFinder::FindPathA(ManagedGraph^ graph, ManagedNode^ start, ManagedNode^ end)
		// {
		// 	// return mPathFinder->FindPath(std::make_shared<Node>(marshal_as<Node*>(start)), std::make_shared<Node>(marshal_as<Node*>(end)));
		// 	// auto deck = gcnew cliext::deque<Library::Cli::ManagedNode^>();
		// 	mPathFinder->FindPath(std::make_shared<Node>(start->UnmanagedNode), std::make_shared<Node>(end->UnmanagedNode));
		// 
		// 	// for (auto val : retVal)
		// 	// {
		// 	// 	Library::Cli::ManagedNode^ node = graph[val.get()->Location];
		// 	// 
		// 	// 	deck->Add(node);
		// 	// }
		// }
	}
}