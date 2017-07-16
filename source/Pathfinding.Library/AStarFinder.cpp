#include "pch.h"
#include "AStarFinder.h"
#include "Heuristics.h"

namespace Library
{
	AStarFinder::AStarFinder(HeuristicFn_t heuristicFunction, CostFn_t costFunction)
		: IPathFinder(heuristicFunction, costFunction)
	{
	}

	std::deque<NodePtr> AStarFinder::FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet)
	{
		std::deque<NodePtr> path;
		std::priority_queue<NodePtr, std::vector<NodePtr>, Heuristics::GreaterThan> frontier;
		closedSet.clear();

		frontier.push(start);
		closedSet.insert(start);

		bool foundPath = false;

		while (frontier.size() > 0)
		{
			auto node = frontier.top();
			frontier.pop();

			for (auto neighbor : node->Neighbors())
			{
				auto neighborShared = neighbor.lock();
				float pathCost = node->PathCost() + (mCostFunction ? mCostFunction(node, neighborShared) : 0);
				float heuristic = mHeuristicFunction ? mHeuristicFunction(neighborShared, end) : 0;
				float newCost = pathCost + heuristic;
				if (closedSet.find(neighborShared) == closedSet.end() || newCost < neighborShared->TotalCost())
				{
					neighborShared->SetPathCost(pathCost);
					neighborShared->SetHeuristic(heuristic);
					neighborShared->SetParent(node);
					frontier.push(neighborShared);
					closedSet.insert(neighborShared);

					if (neighborShared == end)
					{
						foundPath = true;
						break;
					}
				}
			}

			if (foundPath)
			{
				break;
			}
		}

		if (foundPath)
		{
			NodePtr current = end;

			path.push_front(end);

			while (current != start)
			{
				NodePtr parent = current->Parent().lock();
				path.push_front(parent);
				current = parent;
			}

		}

		return path;
	}

	std::string AStarFinder::GetName() const
	{
		return std::string("A* Search");
	}
}
