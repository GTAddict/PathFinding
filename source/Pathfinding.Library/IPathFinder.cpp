#include "pch.h"
#include "IPathFinder.h"

using namespace std;

namespace Library
{
	IPathFinder::IPathFinder(HeuristicType heuristic)
		: mHeuristicFunction(heuristic)
	{
	}

	deque<NodePtr> IPathFinder::FindPath(NodePtr start, NodePtr end)
	{
		set<NodePtr> closedSet;
		return FindPath(start, end, closedSet);
	}

	void IPathFinder::SetHeuristicFunction(HeuristicType function)
	{
		mHeuristicFunction = function;
	}
}
