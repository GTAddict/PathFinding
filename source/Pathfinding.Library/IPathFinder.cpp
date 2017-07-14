#include "pch.h"
#include "IPathFinder.h"

using namespace std;

namespace Library
{
	IPathFinder::IPathFinder(HeuristicFn_t heuristicFunction, CostFn_t costFunction)
		: mHeuristicFunction(heuristicFunction)
		, mCostFunction(costFunction)
	{
	}

	deque<NodePtr> IPathFinder::FindPath(NodePtr start, NodePtr end)
	{
		set<NodePtr> closedSet;
		return FindPath(start, end, closedSet);
	}

	void IPathFinder::SetHeuristicFunction(HeuristicFn_t function)
	{
		mHeuristicFunction = function;
	}

	void IPathFinder::SetCostFunction(CostFn_t function)
	{
		mCostFunction = function;
	}
}
