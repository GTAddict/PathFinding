#include "pch.h"
#include "DijkstrasFinder.h"
#include "Heuristics.h"

namespace Library
{
	DijkstrasFinder::DijkstrasFinder(CostFn_t costFunction)
		: IPathFinder(nullptr, costFunction)
	{
	}

	std::deque<NodePtr> DijkstrasFinder::FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet)
	{
		std::deque<NodePtr> path;
		std::priority_queue<NodePtr, std::vector<NodePtr>, Heuristics::GreaterThan> frontier;
		
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
				float newCost = node->PathCost() + mCostFunction(node, neighborShared);
				if (closedSet.find(neighborShared) == closedSet.end() || newCost < neighborShared->PathCost())
				{
					neighborShared->SetPathCost(newCost);
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
}
